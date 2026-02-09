using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PortafolioNegocio
    {

       public List<Portafolio> ListaPortafolio()
       {

            List<Portafolio> lista = new List<Portafolio>();

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {

                accesoDatos.SetearConsulta("select IdPortafolio,UrlImagen,Titulo from Portafolio where Activo=1");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                       Portafolio aux = new Portafolio();

                    aux.IdPortafolio = (int)accesoDatos.Lector["IdPortafolio"];
                    aux.Titulo = (string)accesoDatos.Lector["Titulo"];
                    aux.UrlImagen = (string)accesoDatos.Lector["UrlImagen"];

                      
                     
                     lista.Add(aux);
                                    
                
                }



            return lista;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }








       }

        public void AgregarImagen(Portafolio portafolio)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("insert into  Portafolio (UrlImagen,Titulo,Activo) values(@UrlImagen,@Titulo,1)");
                
                accesoDatos.SetearParametro("@UrlImagen", portafolio.UrlImagen);
                accesoDatos.SetearParametro("@Titulo", portafolio.Titulo);

                accesoDatos.EjecutarAccion();







            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.CerrarConexion(); }

               





        }




    }
}
