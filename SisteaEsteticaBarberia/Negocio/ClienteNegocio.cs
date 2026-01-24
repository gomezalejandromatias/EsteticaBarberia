using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {

        public List<Cliente> ListaCliente()
        {
            List<Cliente> lista = new List<Cliente>();

            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetearConsulta(
           "SELECT IdCliente, Nombre, Dni, Telefono, Email, Activo " +
           "FROM Cliente " +
           "WHERE Activo = 1"
       );
            accesoDatos.EjecutarLectura();

            try
            {
                Cliente aux = new Cliente();

                while (accesoDatos.Lector.Read())
                {
                    aux.IdCliente = (int)accesoDatos.Lector["IdCliente"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Dni = (string)accesoDatos.Lector["Dni"];
                    aux.Email = (string)accesoDatos.Lector["Email"];
                    aux.Telefono = (string)accesoDatos.Lector["Telefono"];
                    aux.Activo = (bool)accesoDatos.Lector["Activo"];



                    lista.Add(aux);


                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }






          



        }


        public void AgregarCliente(Cliente cliente)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {


                accesoDatos.SetearConsulta("insert into Cliente (Nombre,Dni,Telefono,Email) Values (@Nombre,@Dni,@Telefono,@Email ");

                accesoDatos.SetearParametro("@Nombre",cliente.Nombre);
                accesoDatos.SetearParametro("@Dni",cliente.Dni);
                accesoDatos.SetearParametro("@Telefono",cliente.Telefono);
                accesoDatos.SetearParametro("@Email",cliente.Email);

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
