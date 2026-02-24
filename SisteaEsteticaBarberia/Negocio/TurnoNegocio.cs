using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> ListaTurno()
        {
            Dictionary<int, Turno> TurnoDiccionary = new Dictionary<int, Turno>();
            List<Turno> lista = new List<Turno>();

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta(@"
    SELECT
        tg.IdTurnoGrupo AS IdTurno,
        tg.Inicio,
        tg.Fin,
        tg.Estado,

        c.IdCliente,
        c.Nombre,
        c.Telefono,

        ts.IdTipoServicio,
        ts.Servicio      AS Servicio,
        ts.PrecioServicio AS PrecioServicio
    FROM TurnoGrupo tg
    JOIN TurnoGrupoCliente tgc 
        ON tgc.IdTurnoGrupo = tg.IdTurnoGrupo
    JOIN Cliente c 
        ON c.IdCliente = tgc.IdCliente
    JOIN Servicio s 
        ON s.IdTurnoGrupo = tg.IdTurnoGrupo 
       AND s.IdCliente = c.IdCliente
    JOIN ServicioTipoServicio sts 
        ON sts.IdServicio = s.IdServicio
    JOIN TipoServicio ts 
        ON ts.IdTipoServicio = sts.IdTipoServicio
    WHERE tg.Activo = 1
      AND CONVERT(date, tg.Inicio) >= CONVERT(date, GETDATE()) and tg.Estado <> 'Cancelado'
ORDER BY tg.IdTurnoGrupo, c.IdCliente, ts.IdTipoServicio
");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    int IdTurno = (int)accesoDatos.Lector["IdTurno"];
                    int IdCliente = (int)accesoDatos.Lector["IdCliente"];
                    int IdTipoServicio = (int)accesoDatos.Lector["IdTipoServicio"];
                    if (TurnoDiccionary.ContainsKey(IdTurno) == false)
                    {

                        Turno turno = new Turno();

                        turno.IdTurno = IdTurno;
                        turno.Inicio = (DateTime)accesoDatos.Lector["Inicio"];
                        turno.Fin = (DateTime)accesoDatos.Lector["Fin"];
                        turno.Estado = (string)accesoDatos.Lector["Estado"];



                        TurnoDiccionary.Add(IdTurno, turno);
                    }


                    Turno turno1 = TurnoDiccionary[IdTurno];

                    ClienteTurno clienteTurno = null;

                    foreach (ClienteTurno item in turno1.clienteTurnos)
                    {
                        if (item.Cliente.IdCliente == IdCliente)
                        {

                            clienteTurno = item;
                            break;


                        }


                    }

                    if (clienteTurno == null)
                    {

                        clienteTurno = new ClienteTurno();

                        clienteTurno.Cliente.IdCliente = IdCliente;
                        clienteTurno.Turno = turno1;
                        clienteTurno.Cliente.Nombre = (string)accesoDatos.Lector["Nombre"];
                        clienteTurno.Cliente.Telefono = (string)accesoDatos.Lector["Telefono"];

                        turno1.clienteTurnos.Add(clienteTurno);




                    }

                    Servicio servicioContenedor = null;

                    if (clienteTurno.servicios.Count > 0)
                    {
                        servicioContenedor = clienteTurno.servicios[0];
                    }
                    else
                    {
                        servicioContenedor = new Servicio();
                        // IMPORTANTE: Servicio debe tener su lista inicializada (en clase o acá)
                        // servicioContenedor.tipoServicios = new List<TipoServicio>();

                        clienteTurno.servicios.Add(servicioContenedor);
                    }

                    // ====== TIPO SERVICIO (dentro del servicioContenedor) ======
                    TipoServicio tipo = null;

                    foreach (TipoServicio t in servicioContenedor.tipoServicios)
                    {
                        if (t.IdTipoServicio == IdTipoServicio)
                        {
                            tipo = t;
                            break;
                        }
                    }

                    if (tipo == null)
                    {
                        tipo = new TipoServicio();
                        tipo.IdTipoServicio = IdTipoServicio;
                        tipo.Servicio = (string)accesoDatos.Lector["Servicio"];
                        tipo.PrecioServicio = (decimal)accesoDatos.Lector["PrecioServicio"];

                        servicioContenedor.tipoServicios.Add(tipo);
                    }
                }

                lista = TurnoDiccionary.Values.ToList();
                return lista;








            }











            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }















        }

        public void AgregarTurno(Turno turno)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("insert into TurnoGrupo (Inicio,Fin,Estado)values(@Inicio,@Fin,@Estado) select scope_identity();");
                accesoDatos.SetearParametro("@Inicio", turno.Inicio);
                accesoDatos.SetearParametro("@Fin", turno.Fin);
                accesoDatos.SetearParametro("@Estado", turno.Estado);
                int IdTurnoGrupo = Convert.ToInt32((decimal)(accesoDatos.EjecutarEscalar()));

                foreach (ClienteTurno ct in turno.clienteTurnos)
                {
                    int idCliente = ct.Cliente.IdCliente;


                    // 2a) PUENTE TurnoGrupoCliente
                    accesoDatos.SetearConsulta(
                        "INSERT INTO TurnoGrupoCliente (IdTurnoGrupo, IdCliente) " +
                        "VALUES (@IdTurnoGrupo, @IdCliente)"
                    );
                    accesoDatos.SetearParametro("@IdTurnoGrupo", IdTurnoGrupo);
                    accesoDatos.SetearParametro("@IdCliente", idCliente);
                    accesoDatos.EjecutarAccion();

                    decimal total = 0;
                    foreach (TipoServicio tipoServicio in ct.servicios[0].tipoServicios)
                    {

                        total += tipoServicio.PrecioServicio;


                    }

                    // 2b) SERVICIO (1 por cliente en ese turno)
                    accesoDatos.SetearConsulta(
                        "INSERT INTO Servicio (IdTurnoGrupo, IdCliente, FechaServicio,TotalServicio,ObservacionServicio) " +
                        "VALUES (@IdTurnoGrupo, @IdCliente, GETDATE(),@TotalServicio,@ObservacionServicio); " +
                        "SELECT SCOPE_IDENTITY();"
                    );
                    accesoDatos.SetearParametro("@IdTurnoGrupo", IdTurnoGrupo);
                    accesoDatos.SetearParametro("@IdCliente", idCliente);
                    accesoDatos.SetearParametro("@TotalServicio", total);
                    accesoDatos.SetearParametro("@ObservacionServicio", DBNull.Value);

                    int idServicio = Convert.ToInt32((decimal)accesoDatos.EjecutarEscalar());

                    // 2c) DETALLE: pelo/barba/etc (desde ct.servicios[0].tipoServicios)
                    // (asumo que ct.servicios tiene 1 item, como vos venías haciendo)
                    foreach (TipoServicio ts in ct.servicios[0].tipoServicios)
                    {
                        accesoDatos.SetearConsulta(
                            "INSERT INTO ServicioTipoServicio (IdServicio, IdTipoServicio, PrecioAplicado, Cantidad) " +
                            "VALUES (@IdServicio, @IdTipoServicio, @PrecioAplicado, 1)"
                        );
                        accesoDatos.SetearParametro("@IdServicio", idServicio);
                        accesoDatos.SetearParametro("@IdTipoServicio", ts.IdTipoServicio);
                        accesoDatos.SetearParametro("@PrecioAplicado", ts.PrecioServicio);

                        accesoDatos.EjecutarAccion();
                    }
                }





            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




        }


        public bool TurnoRepetido(DateTime inicio, DateTime fin)


        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"
            SELECT COUNT(1)
            FROM TurnoGrupo
            WHERE Estado <> 'Cancelado'
              AND CONVERT(date, Inicio) = CONVERT(date, @Inicio)
              AND (@Inicio < Fin AND @Fin > Inicio)
        ");

                datos.SetearParametro("@Inicio", inicio);
                datos.SetearParametro("@Fin", fin);

                int cantidad = Convert.ToInt32(datos.EjecutarEscalar());
                return cantidad > 0;


            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void ModificarTurno(TurnoListaDto turno)
        {

            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {
                accesoDatos.SetearConsulta("update TurnoGrupo set Inicio =@Inicio,Fin = @Fin where IdTurnoGrupo=@IdTurnoGrupo");

                accesoDatos.SetearParametro("@Inicio", turno.Inicio);
                accesoDatos.SetearParametro("@Fin", turno.Fin);
                accesoDatos.SetearParametro("@IdTurnoGrupo", turno.IdTurno);



                accesoDatos.EjecutarAccion();











            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }





        }

        public void CancelarTurno(TurnoListaDto turno)
        {

            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {
                accesoDatos.SetearConsulta("update TurnoGrupo set Estado = @Estado where IdTurnoGrupo = @IdTurnoGrupo");
                accesoDatos.SetearParametro("@IdTurnoGrupo", turno.IdTurno);
                accesoDatos.SetearParametro("@Estado", turno.Estado);
                accesoDatos.EjecutarAccion();



            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { accesoDatos.CerrarConexion(); }


        }

        public void TurnoAtendido(TurnoListaDto turnoListaDto)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("update TurnoGrupo set Estado = @Estado where IdTurnoGrupo=@IdTurnoGrupo");
                accesoDatos.SetearParametro("@IdturnoGrupo", turnoListaDto.IdTurno);
                accesoDatos.SetearParametro("@Estado", turnoListaDto.Estado);

                accesoDatos.EjecutarAccion();




            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }



        }
        public void TurnoCancelado(TurnoListaDto turnoListaDto)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("update TurnoGrupo set Estado = @Estado where IdTurnoGrupo=@IdTurnoGrupo");
                accesoDatos.SetearParametro("@IdturnoGrupo", turnoListaDto.IdTurno);
                accesoDatos.SetearParametro("@Estado", turnoListaDto.Estado);

                accesoDatos.EjecutarAccion();




            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




        }

        public void ModificarServicio(Turno turno)
        {


            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {


                foreach (ClienteTurno clienteTurno in turno.clienteTurnos)
                {
                    int idcliente = clienteTurno.Cliente.IdCliente;
                    int idturno = clienteTurno.Turno.IdTurno;

                    decimal total = 0;
                    foreach (TipoServicio item in clienteTurno.servicios[0].tipoServicios)
                    {

                        total += item.PrecioServicio;


                    }
                    accesoDatos.SetearConsulta(
   "SELECT IdServicio FROM Servicio WHERE IdTurnoGrupo=@IdTurnoGrupo AND IdCliente=@IdCliente"
);
                    accesoDatos.SetearParametro("@IdTurnoGrupo", idturno);
                    accesoDatos.SetearParametro("@IdCliente", idcliente);

                    object aux = accesoDatos.EjecutarEscalar();
                    int idServicio = Convert.ToInt32(aux);

                    accesoDatos.SetearConsulta("update servicio set TotalServicio=@TotalServicio where IdTurnoGrupo=@IdTurnoGrupo and IdCliente=@IdCliente");

                    accesoDatos.SetearParametro("@IdTurnoGrupo",idturno);
                    accesoDatos.SetearParametro("@IdCliente", idcliente);
                    accesoDatos.SetearParametro("@TotalServicio", total);

                    accesoDatos.EjecutarAccion();

                    // BORRAR TODOS los tipos anteriores
                    accesoDatos.SetearConsulta("DELETE FROM ServicioTipoServicio WHERE IdServicio=@IdServicio");
                    accesoDatos.SetearParametro("@IdServicio", idServicio);
                    accesoDatos.EjecutarAccion();

                    foreach (TipoServicio item in clienteTurno.servicios[0].tipoServicios)
                    {
                        accesoDatos.SetearConsulta(
                            "INSERT INTO ServicioTipoServicio (IdServicio, IdTipoServicio, PrecioAplicado) " +
                            "VALUES (@IdServicio, @IdTipoServicio, @PrecioAplicado)"
                        );

                        accesoDatos.SetearParametro("@IdServicio", idServicio);
                        accesoDatos.SetearParametro("@IdTipoServicio", item.IdTipoServicio);
                        accesoDatos.SetearParametro("@PrecioAplicado", item.PrecioServicio);

                        accesoDatos.EjecutarAccion();
                    }




                }

               








            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }




        }
        public List<Turno> ListaHistorial(string estado = null)
        {
            Dictionary<int, Turno> turnosDic = new Dictionary<int, Turno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"
SELECT
    tg.IdTurnoGrupo AS IdTurno,
    tg.Inicio,
    tg.Fin,
    tg.Estado,

    c.IdCliente,
    c.Nombre,
    c.Telefono,

    ts.IdTipoServicio,
    ts.Servicio       AS Servicio,
    ts.PrecioServicio AS PrecioServicio
FROM TurnoGrupo tg
JOIN TurnoGrupoCliente tgc 
    ON tgc.IdTurnoGrupo = tg.IdTurnoGrupo
JOIN Cliente c 
    ON c.IdCliente = tgc.IdCliente
JOIN Servicio s 
    ON s.IdTurnoGrupo = tg.IdTurnoGrupo 
   AND s.IdCliente = c.IdCliente
JOIN ServicioTipoServicio sts 
    ON sts.IdServicio = s.IdServicio
JOIN TipoServicio ts 
    ON ts.IdTipoServicio = sts.IdTipoServicio
WHERE tg.Activo = 1
  AND (@Estado IS NULL OR tg.Estado = @Estado)
ORDER BY tg.IdTurnoGrupo, c.IdCliente, ts.IdTipoServicio
");

                datos.SetearParametro("@Estado", (object)estado ?? DBNull.Value);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    int idTurno = (int)datos.Lector["IdTurno"];
                    int idCliente = (int)datos.Lector["IdCliente"];
                    int idTipoServicio = (int)datos.Lector["IdTipoServicio"];

                    // 1) Turno (no repetir)
                    if (turnosDic.ContainsKey(idTurno) == false)
                    {
                        Turno t = new Turno();
                        t.IdTurno = idTurno;
                        t.Inicio = (DateTime)datos.Lector["Inicio"];
                        t.Fin = (DateTime)datos.Lector["Fin"];
                        t.Estado = (string)datos.Lector["Estado"];

                        turnosDic.Add(idTurno, t);
                    }

                    Turno turno = turnosDic[idTurno];

                    // 2) ClienteTurno (no repetir dentro del turno)
                    ClienteTurno ctEncontrado = null;
                    foreach (ClienteTurno ct in turno.clienteTurnos)
                    {
                        if (ct.Cliente.IdCliente == idCliente)
                        {
                            ctEncontrado = ct;
                            break;
                        }
                    }

                    if (ctEncontrado == null)
                    {
                        ctEncontrado = new ClienteTurno();
                        ctEncontrado.Cliente.IdCliente = idCliente;
                        ctEncontrado.Cliente.Nombre = (string)datos.Lector["Nombre"];
                        ctEncontrado.Cliente.Telefono = (string)datos.Lector["Telefono"];
                        ctEncontrado.Turno = turno;

                        turno.clienteTurnos.Add(ctEncontrado);
                    }

                    // 3) Servicio contenedor (1 por cliente, para agrupar tipos)
                    Servicio servicioContenedor;
                    if (ctEncontrado.servicios.Count > 0)
                    {
                        servicioContenedor = ctEncontrado.servicios[0];
                    }
                    else
                    {
                        servicioContenedor = new Servicio();

                        // por si tu clase Servicio NO inicializa la lista:
                        if (servicioContenedor.tipoServicios == null)
                            servicioContenedor.tipoServicios = new List<TipoServicio>();

                        ctEncontrado.servicios.Add(servicioContenedor);
                    }

                    // 4) TipoServicio (no repetir dentro del servicioContenedor)
                    TipoServicio tipo = null;
                    foreach (TipoServicio x in servicioContenedor.tipoServicios)
                    {
                        if (x.IdTipoServicio == idTipoServicio)
                        {
                            tipo = x;
                            break;
                        }
                    }

                    if (tipo == null)
                    {
                        tipo = new TipoServicio();
                        tipo.IdTipoServicio = idTipoServicio;
                        tipo.Servicio = (string)datos.Lector["Servicio"];
                        tipo.PrecioServicio = (decimal)datos.Lector["PrecioServicio"];

                        servicioContenedor.tipoServicios.Add(tipo);
                    }
                }

                return turnosDic.Values.ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }





    }
}
