using System;
using System.Collections.Generic;
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






        }







    }
}
