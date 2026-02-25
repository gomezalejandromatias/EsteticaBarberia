using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Negocio;

namespace SisteaEsteticaBarberia
{
    public partial class FrmPortafolio : Form
    {
        Portafolio portafolio = new Portafolio();
        Portafolio Seleccionar = new Portafolio();
        List<Portafolio> listafiltrada;


        public FrmPortafolio()
        {
            InitializeComponent();
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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
            Limpiar();




        }

        private void FrmPortafolio_Load(object sender, EventArgs e)
        {
            btnModificarDefinitivoTitulo.Visible = false;
            CargarGrillImagen();

            btnTituloImagen.Visible = false;
            btnModicarDefinitivoImagen.Visible = false;


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

            if (filtro != "")
            {


                listafiltrada = lista
           .Where(x => x.Titulo.ToLower().Contains(filtro.ToLower()))
                .ToList();


            }

            else { listafiltrada = lista; }




            dgvImagen.DataSource = null;
            dgvImagen.DataSource = listafiltrada;

            dgvImagen.Columns["IdPortafolio"].Visible = false;
            dgvImagen.Columns["UrlImagen"].Visible = false;
            dgvImagen.Columns["Activo"].Visible = false;
            dgvImagen.Columns["TipoServicio"].Visible = false;



        }

        private void btnElegirImagenPc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes (*.jpg;*.png)|*.jpg;*.png";
            ofd.Title = "Seleccionar imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Carpeta destino del sistema
                string carpetaImagenes = @"C:\SistemaEsteticaBarberia\Imagenes\";

                // Si no existe, la crea
                if (!Directory.Exists(carpetaImagenes))
                {
                    Directory.CreateDirectory(carpetaImagenes);
                }

                // Nombre único para evitar pisar imágenes
                string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);

                // Ruta final
                string rutaDestino = Path.Combine(carpetaImagenes, nombreArchivo);

                // Copia la imagen
                File.Copy(ofd.FileName, rutaDestino, true);

                // Guardás la ruta (esto va a la DB)
                txtUrlImagen.Text = rutaDestino;

                // Mostrás la imagen
                pbImagen.ImageLocation = rutaDestino;
            }
        }

        private void Limpiar()
        {

            txtFiltro.Text = "";
            txtTitulo.Text = "";
            txtUrlImagen.Text = "";

            txtTitulo.Focus();




        }

        private void btnModificarTitulo_Click(object sender, EventArgs e)
        {

            Seleccionar = (Portafolio)dgvImagen.CurrentRow.DataBoundItem;

            txtTitulo.Text = Seleccionar.Titulo;

            txtUrlImagen.Enabled = false;

            btnTituloImagen.Visible = true;

            btnElegirImagenPc.Enabled = false;

            btnModificarDefinitivoTitulo.Visible = true;


        }

        private void btnTituloImagen_Click(object sender, EventArgs e)
        {

            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();


            int idportafolio = Seleccionar.IdPortafolio;

            try
            {

                DialogResult respuesta = MessageBox.Show("Desea Modificar El Titulo De La Imagen?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Seleccionar.Titulo = txtTitulo.Text;
                    Seleccionar.IdPortafolio = idportafolio;

                    portafolioNegocio.ModificarTitulo(Seleccionar);

                }

                MessageBox.Show("Bien");





            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrillImagen();

            btnTituloImagen.Visible = false;
            txtUrlImagen.Enabled = true;
            Limpiar();

        }

        public void OcultarBotones()
        {

            btnAgregarImagen.Visible = false;
            btnEliminarImagen.Visible = false;

            // btnModicarDefinitivoImagen.Visible = false;
            btnModificarImagen.Visible = false;






        }
        public void VisiilizarImagen()
        {

            btnAgregarImagen.Visible = true;
            btnEliminarImagen.Visible = true;

            //  btnModicarDefinitivoImagen.Visible = true;
            btnModificarImagen.Visible = true;
            btnModificarTitulo.Visible = true;






        }

        private void btnModificarImagen_Click(object sender, EventArgs e)
        {
            Seleccionar = (Portafolio)dgvImagen.CurrentRow.DataBoundItem;

            txtUrlImagen.Text = Seleccionar.UrlImagen;

            btnModicarDefinitivoImagen.Visible = true;

            OcultarBotones();

            btnModificarTitulo.Visible = false;
            txtTitulo.Enabled = false;




        }

        private void btnModicarDefinitivoImagen_Click(object sender, EventArgs e)
        {
            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();

            int id = Seleccionar.IdPortafolio;

            try
            {

                DialogResult respuesta = MessageBox.Show("Desea Modificar El Titulo De La Imagen?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Seleccionar.UrlImagen = txtUrlImagen.Text;
                    Seleccionar.IdPortafolio = id;

                    portafolioNegocio.ModificarImagen(Seleccionar);

                    MessageBox.Show("Bien");
                }






            }
            catch (Exception ex)
            {

                throw ex;
            }


            VisiilizarImagen();
            btnModicarDefinitivoImagen.Visible = false;
            txtTitulo.Enabled = true;
            CargarGrillImagen();
            txtUrlImagen.Text = "";
        }

        private void btnModificarDefinitivoTitulo_Click(object sender, EventArgs e)
        {

            PortafolioNegocio portafolioNegocio = new PortafolioNegocio();




            try
            {

                DialogResult respuesta = MessageBox.Show("Desea Modificar El Titulo De La Imagen?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Seleccionar.Titulo = txtTitulo.Text;
                   

                    portafolioNegocio.ModificarTitulo(Seleccionar);

                    MessageBox.Show("Bien");
                }







            }
            catch (Exception ex)
            {

                throw ex;
            }

            txtTitulo.Text = "";

            txtUrlImagen.Enabled = true;

            btnTituloImagen.Visible = false;

            btnElegirImagenPc.Enabled = true;

            btnModificarDefinitivoTitulo.Visible = false;

            CargarGrillImagen();
            Limpiar();

            txtTitulo.Focus();


        }
    }
}
