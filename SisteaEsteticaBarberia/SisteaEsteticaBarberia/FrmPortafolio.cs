using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace SisteaEsteticaBarberia
{
    public partial class FrmPortafolio : Form
    {
         Portafolio portafolio = new Portafolio();
        Portafolio SeleccionarImagen;
        List<Portafolio> listafiltrada;


        public FrmPortafolio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {


            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();
            try
            {

            portafolio.Titulo = txtTitulo.Text;

            portafolio.UrlImagen = txtUrlImagen.Text;


            portafolioNegocio.AgregarImagen(portafolio);

                MessageBox.Show("bien");
            }
            catch (Exception ex)
            {

                throw ex;
            }



            CargarGrillImagen();




        }

        private void FrmPortafolio_Load(object sender, EventArgs e)
        {

            CargarGrillImagen();


        }


        private void CargarGrillImagen()
        {


            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();


            dgvImagen.DataSource = null;
            dgvImagen.DataSource = portafolioNegocio.ListaPortafolio();
            dgvImagen.Columns["IdPortafolio"].Visible = false;
            dgvImagen.Columns["UrlImagen"].Visible = false;
            dgvImagen.Columns["Activo"].Visible = false;
            dgvImagen.Columns["TipoServicio"].Visible = false;


        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

  
              




        }

        private void dgvImagen_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvImagen.CurrentRow == null)
                return;

            Portafolio seleccionado =
                (Portafolio)dgvImagen.CurrentRow.DataBoundItem;

            pbImagen.ImageLocation = seleccionado.UrlImagen;

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();

            string filtro = txtFiltro.Text;

            var lista = portafolioNegocio.ListaPortafolio();

            if(filtro!= ""){
            
            
                  listafiltrada = lista
             .Where(x => x.Titulo.ToLower().Contains(filtro.ToLower()))
                  .ToList();
            
            
            }

            else { listafiltrada = lista;   }




            dgvImagen.DataSource = null;
            dgvImagen.DataSource = listafiltrada;

            dgvImagen.Columns["IdPortafolio"].Visible = false;
            dgvImagen.Columns["UrlImagen"].Visible = false;
            dgvImagen.Columns["Activo"].Visible = false;
            dgvImagen.Columns["TipoServicio"].Visible = false;



        }
    }
}
