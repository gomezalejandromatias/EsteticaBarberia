using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisteaEsteticaBarberia
{
    public partial class FrmProductosServicios : Form
    {
         TipoServicio tipoServicio = new TipoServicio();
        Producto producto;
         
        public FrmProductosServicios()
        {
            InitializeComponent();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {


               TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

                tipoServicio.Servicio = txtNombreServicio.Text;

                 tipoServicio.PrecioServicio = decimal.Parse (txtPrecioServicio.Text );


            tipoServicioNegocio.AgregarTipoServicio(tipoServicio);

            CargarGrillaServico();

               
                

        }

        private void FrmProductosServicios_Load(object sender, EventArgs e)
        {
            CargarGrillaServico();
            CargarGrillaProducto();
        }

         private void CargarGrillaServico()
         {

            TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

            dgvTipoServicio.DataSource = null;
            dgvTipoServicio.DataSource = tipoServicioNegocio.ListaTipoServicio();


            dgvTipoServicio.Columns["IdTipoServicio"].Visible = false; // ajustá el nombre si es distinto
            dgvTipoServicio.Columns["Activo"].Visible = false;


        }
        private void CargarGrillaProducto()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();    

            dgvProducto.DataSource = null;
            dgvProducto.DataSource = productoNegocio.ListaProducto();

            dgvProducto.Columns["idProducto"].Visible = false; // ajustá el nombre si es distinto
            dgvProducto.Columns["Activo"].Visible = false;

        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

             ProductoNegocio productoNegocio = new ProductoNegocio();


            producto = new Producto();

            producto.Nombre = txtNombre.Text;
            producto.Precio= decimal.Parse(txtPrecioProducto.Text );
            producto.Cantidad = int.Parse(txtCantidadProducto.Text );
            producto.UnidadMedida = txtUnidadMedida.Text;
            producto.FechaVencimiento = dtpProducto.Value.Date;

            producto.Categoria = txtCategoria.Text;
            producto.StockActual = producto.Cantidad;

            productoNegocio.AgregarProducto(producto);

            MessageBox.Show("bien");

            CargarGrillaProducto();

        }



        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            


            
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            Stock();
        }
        private void Stock() 
        {


            txtStock.Text = txtCantidadProducto.Text;
             
           
        
        
        }
    }
}
