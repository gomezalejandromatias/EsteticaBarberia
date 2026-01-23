using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
namespace SisteaEsteticaBarberia
{
    public partial class Form1 : Form
    { 
      public List<Turno>turnos = new List<Turno>();

        public List<Cliente> listacliente = new List<Cliente>();
        public Cliente Cliente;
      
        public TipoServicio seleccionado;

        public Turno Turno;

        ClienteTurno ClienteTurno;

        public List<ClienteTurno> listaturnocliente =  new List<ClienteTurno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            lblSinTurno.Visible = false;
            CargarGrillaCliente();
            CargarComboBox();

            
        }


        public void CargarGrilla()
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            turnos = turnoNegocio.ListaTurno();
            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = turnos;

            MostrarTurno();




        }

        private void dtpHoraVerTurnos_ValueChanged(object sender, EventArgs e)
        {

            MostrarTurno();

        }

        private void MostrarTurno()
        {

            DateTime TomarFecha = dtpHoraVerTurnos.Value.Date;

            List<Turno> listafiltrada;

            
            
                listafiltrada = turnos.Where(f => f.Inicio.Date == TomarFecha).ToList();


            

             dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = listafiltrada;


             if (listafiltrada.Count == 0) 
             {
                lblSinTurno.Visible = true;
                lblSinTurno.Text = "No Hay Turnos Para Esta Fecha";
                
            
             }

            else { lblSinTurno.Visible=false;}



        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            Cliente = new Cliente();
            try
            {
            Cliente.Nombre = txtNombre.Text;
            Cliente.Dni = txtNombre.Text;
            Cliente.Email = txtEmail.Text;
            Cliente.Telefono = txtTelefono.Text;

                MessageBox.Show("Cliente Agregado Con Exito");

            }
            catch (Exception ex)
            {

                throw ex;
            }


            listacliente.Add(Cliente);


            CargarGrillaCliente();

        }

        public void CargarGrillaCliente()
        {


            dgvCliente.DataSource = null;
            dgvCliente.DataSource = listacliente;



        }
        private void CargarComboBox()
        {
            TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

           
            cbTipoServicio.DataSource = tipoServicioNegocio.ListaTipoServicio();
            
            cbTipoServicio.DisplayMember = "Servicio";
            cbTipoServicio.ValueMember = "IdTipoServicio";


        }
        private void SeleccionarCombobox()
        {
              
            



        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {

        
                          


            ClienteTurno = new ClienteTurno();
  

            ClienteTurno.Cliente.Dni = txtDni.Text;
            ClienteTurno.Cliente.Nombre = txtNombre.Text;
            ClienteTurno.Cliente.Email = txtEmail.Text; 
            ClienteTurno.Cliente.Telefono = txtTelefono.Text;

            ClienteTurno.Turno.Inicio = dtpHoraInicioTurno.Value.Date
             + dtpHoraInicio.Value.TimeOfDay;

            ClienteTurno.Turno.Fin = dtpHoraFinTurno.Value.Date
                      + dtpHoraFin.Value.TimeOfDay;


            listaturnocliente.Add(ClienteTurno);

            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = listaturnocliente;

        }

    
    }
}
