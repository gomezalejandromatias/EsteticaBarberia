using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ProductoNegocio
    {

      public  List<Producto> ListaProducto()
      {

          List<Producto>lista = new List<Producto>();

            AccesoDatos accesoDatos = new AccesoDatos();

        

            try
            {
                accesoDatos.SetearConsulta(
                    "select IdProducto, Nombre, Categoria, Cantidad, Precio, UnidadMedida, StockActual, FechaVencimiento, Activo " +
                    "from Producto"); 
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Producto aux = new Producto();

                    aux.IdProducto = (int)accesoDatos.Lector["IdProducto"];
                    aux.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    aux.Categoria = accesoDatos.Lector["Categoria"].ToString();

                    aux.Cantidad = Convert.ToInt32(accesoDatos.Lector["Cantidad"]);
                    aux.Precio = Convert.ToDecimal(accesoDatos.Lector["Precio"]);
                    aux.UnidadMedida = accesoDatos.Lector["UnidadMedida"].ToString();

                    aux.StockActual = Convert.ToInt32(accesoDatos.Lector["StockActual"]);

                    if (!(accesoDatos.Lector["FechaVencimiento"] is DBNull))
                        aux.FechaVencimiento = (DateTime)accesoDatos.Lector["FechaVencimiento"];

                    aux.Activo = Convert.ToBoolean(accesoDatos.Lector["Activo"]);

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
        public void AgregarProducto(Producto producto)
        {

            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {
                accesoDatos.SetearConsulta(
                            "insert into Producto (Nombre,Cantidad,Categoria,Precio,UnidadMedida,StockActual,FechaVencimiento,Activo) " +
                            "values (@Nombre,@Cantidad,@Categoria,@Precio,@UnidadMedida,@StockActual,@FechaVencimiento,1)");

                accesoDatos.SetearParametro("@Nombre", producto.Nombre);
                accesoDatos.SetearParametro("@Cantidad", producto.Cantidad);
                accesoDatos.SetearParametro("@Categoria", producto.Categoria);
                accesoDatos.SetearParametro("@Precio", producto.Precio);
                accesoDatos.SetearParametro("@UnidadMedida", producto.UnidadMedida);
                accesoDatos.SetearParametro("@StockActual", producto.StockActual);

                if (producto.FechaVencimiento != null)
                    accesoDatos.SetearParametro("@FechaVencimiento", producto.FechaVencimiento);
                else
                    accesoDatos.SetearParametro("@FechaVencimiento", DBNull.Value);

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
