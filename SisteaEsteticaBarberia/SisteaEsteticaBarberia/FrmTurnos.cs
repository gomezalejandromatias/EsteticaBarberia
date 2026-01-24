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
    public partial class FrmTurnos : Form
    {
     private         TipoServicio TipoServicio;

     private   List<TipoServicio> ListaServicio = new List<TipoServicio>();


        public FrmTurnos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTurnos_Load(object sender, EventArgs e)
        {
            CargarTipoServicio();
        }

     

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            TipoServicio = new TipoServicio();

            TipoServicio.Servicio = txtNombreServicio.Text;
            TipoServicio.PrecioServicio = decimal.Parse(txtPrecioServicio.Text);


            ListaServicio.Add(TipoServicio);

            CargarTipoServicio();
        }

        private void CargarTipoServicio()
        {


             TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

            dgvTipoServicio.DataSource = null;
            dgvTipoServicio.DataSource = ListaServicio;



        }
    }
}
