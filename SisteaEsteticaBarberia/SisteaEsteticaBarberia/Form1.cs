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
        public List<Turno> turnos = new List<Turno>();

        ///  public List<Cliente> listacliente = new List<Cliente>();

        public Cliente Cliente;

        public TipoServicio seleccionado;


        public Turno Turno;

        ClienteTurno ClienteTurno;

        public List<ClienteTurno> listaturnocliente = new List<ClienteTurno>();

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
            var turnos = turnoNegocio.ListaTurno();

            var grilla = new List<object>();

            foreach (var t in turnos)
            {
                foreach (var ct in t.clienteTurnos)
                {
                    // juntar todos los TipoServicio del cliente (de todos los "Servicio" que tenga)
                    List<string> nombresServicios = new List<string>();
                    decimal total = 0;

                    foreach (var s in ct.servicios)
                    {
                        foreach (var ts in s.tipoServicios)
                        {
                            // evitar repetidos
                            if (nombresServicios.Contains(ts.Servicio) == false)
                                nombresServicios.Add(ts.Servicio);

                            total += ts.PrecioServicio;
                        }
                    }

                    string serviciosTexto = string.Join(", ", nombresServicios);

                    grilla.Add(new
                    {
                        Turno = t.IdTurno,
                        Inicio = t.Inicio,
                        Fin = t.Fin,
                        Estado = t.Estado,
                        Cliente = ct.Cliente.Nombre,
                        Telefono = ct.Cliente.Telefono,
                        Servicios = serviciosTexto,
                        Total = total
                    });
                }
            }

            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = grilla;




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

            else { lblSinTurno.Visible = false; }



        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente = new Cliente();
            try
            {
                Cliente.Nombre = txtNombre.Text;
                Cliente.Dni = txtNombre.Text;
                Cliente.Email = txtEmail.Text;
                Cliente.Telefono = txtTelefono.Text;

                clienteNegocio.AgregarCliente(Cliente);
                MessageBox.Show("Cliente Agregado Con Exito");



            }
            catch (Exception ex)
            {

                throw ex;
            }





            CargarGrillaCliente();

        }

        public void CargarGrillaCliente()
        {
            ClienteNegocio cliente = new ClienteNegocio();

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = cliente.ListaCliente();

            dgvCliente.Columns["IdCliente"].Visible = false;
            dgvCliente.Columns["Activo"].Visible = false;

        }
        private void CargarComboBox()
        {
            TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();


            cbTipoServicio.DataSource = tipoServicioNegocio.ListaTipoServicio();

            cbTipoServicio.DisplayMember = "Servicio";
            cbTipoServicio.ValueMember = "IdTipoServicio";


        }


        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {





            ClienteTurno = new ClienteTurno();
            Servicio nuevo = new Servicio();
            nuevo.tipoServicios.Add(seleccionado);

            ClienteTurno.Cliente.Dni = txtDni.Text;
            ClienteTurno.Cliente.Nombre = txtNombre.Text;
            ClienteTurno.Cliente.Email = txtEmail.Text;
            ClienteTurno.Cliente.Telefono = txtTelefono.Text;

            ClienteTurno.servicios.Add(nuevo);

            ClienteTurno.Turno.Inicio = dtpHoraInicioTurno.Value.Date
             + dtpHoraInicio.Value.TimeOfDay;

            ClienteTurno.Turno.Fin = dtpHoraFinTurno.Value.Date
                      + dtpHoraFin.Value.TimeOfDay;


            listaturnocliente.Add(ClienteTurno);

            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = listaturnocliente;

            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = listaturnocliente;

        }

        private void btnSeleccionServicio_Click(object sender, EventArgs e)
        {
            seleccionado = (TipoServicio)cbTipoServicio.SelectedItem;

        }
    }
}
