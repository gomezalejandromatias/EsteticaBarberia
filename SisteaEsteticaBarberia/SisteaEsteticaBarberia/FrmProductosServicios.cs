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

            CargarGrilla();

               
                

        }

        private void FrmProductosServicios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

         private void CargarGrilla()
        {

            TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

            dgvTipoServicio.DataSource = null;
            dgvTipoServicio.DataSource = tipoServicioNegocio.ListaTipoServicio();





        }
    }
}
