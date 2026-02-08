using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoServicioNegocio
    {

        public List<TipoServicio> ListaTipoServicio()
        {
            List<TipoServicio> lista = new List<TipoServicio>();

                AccesoDatos accesoDatos = new AccesoDatos();


            try
            {

                accesoDatos.SetearConsulta("SELECT IdTipoServicio, PrecioServicio, Servicio FROM TipoServicio WHERE Activo = 1");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    TipoServicio tipoServicio = new TipoServicio();

                    tipoServicio.IdTipoServicio = (int) accesoDatos.Lector["IdTipoServicio"];
                    tipoServicio.PrecioServicio = (decimal) accesoDatos.Lector["PrecioServicio"];
                   tipoServicio.Servicio = (string) accesoDatos.Lector["Servicio"];
                    


                     lista.Add(tipoServicio);



                }

                return lista;




}
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }





        }






    }
}
