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
    public partial class FrmTurnoGrupal : Form
    {
        TipoServicio SeleccionarServico;
        decimal TotalPrecioServico;
        Cliente SeleccionarCliente;
        List<TipoServicio> ListaTipoServicio;
        List<ClienteTurno> ListaClienteTurno = new List<ClienteTurno>();

        Turno TurnoCliente = new Turno();

        public FrmTurnoGrupal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
             




        }

        private void FrmTurnoGrupal_Load(object sender, EventArgs e)
        {
            CargarGrillaCliente();
            CargarComboBoxServicio();
            ModificarListView();

        }

        private void CargarGrillaCliente()
        {

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            List<Cliente> lista = new List<Cliente>();

            lista = clienteNegocio.ListaCliente();

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista;





        }
        private void CargarComboBoxServicio()
        {

              TipoServicioNegocio tipoServicioNegocio = new TipoServicioNegocio();

            List<TipoServicio> lista = new List<TipoServicio>();

            lista = tipoServicioNegocio.ListaTipoServicio();

           
            cbmServicio.DataSource = lista;

          

            cbmServicio.DisplayMember = "Servicio";
            cbmServicio.ValueMember = "IdTipoServicio";

        }

        private void btnAgregarServico_Click(object sender, EventArgs e)
        {
            txtServicio.Text = SeleccionarServico.PrecioServicio.ToString();
            
            ListaTipoServicio.Add(SeleccionarServico);

            TotalPrecioServico += SeleccionarServico.PrecioServicio;

            
        }

        private void cbmServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
          


            SeleccionarServico = (TipoServicio)cbmServicio.SelectedItem;


        }

        private void btnAgregarClienteTurno_Click(object sender, EventArgs e)
        {

            


            if (dgvCliente.CurrentRow != null)
            {
                 SeleccionarCliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;

                ListViewItem item = new ListViewItem(SeleccionarCliente.IdCliente.ToString());
                item.SubItems.Add(SeleccionarCliente.Nombre);
                item.SubItems.Add(SeleccionarCliente.Dni);
                item.SubItems.Add(SeleccionarCliente.Telefono);

                lwCliente.Items.Add(item);
            }



        }

        private void lwCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ModificarListView()
        {


            lwCliente.View = View.Details;
            lwCliente.FullRowSelect = true;
            lwCliente.GridLines = true;

            lwCliente.Columns.Add("ID", 80);
            lwCliente.Columns.Add("Nombre", 150);
            lwCliente.Columns.Add("DNI", 120);
            lwCliente.Columns.Add("Telefono", 120);


        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            ClienteTurno clienteTurno = new ClienteTurno();

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            ////ACA ARMO EL OBJ DE SERVICIO
            Servicio servicio = new Servicio();
            servicio.TotalServicio = TotalPrecioServico;
            servicio.tipoServicios = ListaTipoServicio;

            
            clienteTurno.servicios.Add(servicio);

            ////ACA TOMO LAHORA Y FECHA DEL TURNO
            DateTime Inicio = dtpFechaTurnoInicio.Value.Date + dtpHoraInicio.Value.TimeOfDay;
            DateTime Fin = dtpFechaTurnoFin.Value.Date + dtpHoraFin.Value.TimeOfDay;

            clienteTurno.Turno.Inicio = Inicio;
            clienteTurno.Turno.Fin = Fin;


            ///ACA TOMO AL CLIENTE

            clienteTurno.Cliente.Nombre = SeleccionarCliente.Nombre;
            clienteTurno.Cliente.Telefono = SeleccionarCliente.Telefono;
            clienteTurno.Cliente.IdCliente = SeleccionarCliente.IdCliente;
            clienteTurno.Cliente.Email = SeleccionarCliente.Email;
            clienteTurno.Cliente.Telefono = SeleccionarCliente.Telefono;


            ////ACA LE AMNDO TODO A LA LISTA
            ListaClienteTurno.Add(clienteTurno);
            ///ACA HAGO EL TURNO NUEVO Y LE MANDO LA LISTA CLIENTETURNO QUE TIENE TODOS LOS DATOS PARA AGREGAR EL TURNO

            
            TurnoCliente.clienteTurnos = ListaClienteTurno;
            TurnoCliente.Inicio = Inicio;
            TurnoCliente.Fin = Fin;
            TurnoCliente.Estado = "Confirmado";

            turnoNegocio.AgregarTurno(TurnoCliente);

            ListaClienteTurno.Clear();

            TurnoCliente = null;

        }
    }
}
