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
using System.Security.Cryptography.X509Certificates;
namespace SisteaEsteticaBarberia
{
    public partial class Form1 : Form
    {
        int Idturno = 0;
        public List<Turno> turnos = new List<Turno>();

         public Turno turno;

        public Cliente Cliente;
        public Cliente SeleccionarIdCliente;

        public TipoServicio seleccionado;
        public List<TipoServicio> ListaServicio = new List<TipoServicio>();

        public List<TipoServicio>listamodificarservicio = new List<TipoServicio>();

        decimal totalmodificadoservcicio = 0;
        public TipoServicio modificarservicio;

        public TurnoListaDto modificarturno = new TurnoListaDto();

        ClienteTurno ClienteTurno;

        public List<ClienteTurno> listaturnocliente = new List<ClienteTurno>();
        decimal total = 0;
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

            Limpiar();

            InvisibleTxt();

            dtpHoraVerTurnos.MinDate = DateTime.Today;
            dtpHoraInicioTurno.MinDate = DateTime.Today;
            dtpHoraFinTurno.MinDate = DateTime.Today;
      
       


        }


        public void CargarGrilla()
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            var turnos = turnoNegocio.ListaTurno();



            List<TurnoListaDto> grilla = new List<TurnoListaDto>();

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

                    grilla.Add(new TurnoListaDto
                    {
                        IdTurno = t.IdTurno,
                        Inicio = t.Inicio,
                        Fin = t.Fin,
                        Estado = t.Estado,
                        IdCliente = t.cliente.IdCliente,
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



            Limpiar();

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
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Agregar el Turno?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    TurnoNegocio turnoNegocio = new TurnoNegocio();


                    //armo el obj de clientturno
                    ClienteTurno = new ClienteTurno();
                    //armo el obj de servicio
                    Servicio nuevo = new Servicio();
                    nuevo.tipoServicios = new List<TipoServicio>(ListaServicio);
                    nuevo.TotalServicio = total;

                    ClienteTurno.Cliente.Dni = txtDni.Text;
                    ClienteTurno.Cliente.Nombre = txtNombre.Text;
                    ClienteTurno.Cliente.Email = txtEmail.Text;
                    ClienteTurno.Cliente.Telefono = txtTelefono.Text;

                    ClienteTurno.servicios.Add(nuevo);

                    ClienteTurno.Turno.Inicio = dtpHoraInicioTurno.Value.Date
                     + dtpHoraInicio.Value.TimeOfDay;

                    ClienteTurno.Turno.Fin = dtpHoraFinTurno.Value.Date
                              + dtpHoraFin.Value.TimeOfDay;


                    if (turnoNegocio.TurnoRepetido(dtpHoraInicioTurno.Value.Date + dtpHoraInicio.Value.TimeOfDay, dtpHoraFinTurno.Value.Date + dtpHoraFin.Value.TimeOfDay))
                    {
                        MessageBox.Show("no se puede");

                        return;

                    }

                    ClienteTurno.Cliente.IdCliente = SeleccionarIdCliente.IdCliente;

                    //importante aca vacio la lista para qu en el segundo clik
                    //la lista no quede con el clinete/turno anterior
                    listaturnocliente.Clear();

                    listaturnocliente.Add(ClienteTurno);

                    turno = new Turno();

                    turno.clienteTurnos = listaturnocliente;
                    turno.Inicio = ClienteTurno.Turno.Inicio;
                    turno.Fin = ClienteTurno.Turno.Fin;
                    turno.Estado = "Confirmado";

                    turnoNegocio.AgregarTurno(turno);

                    MessageBox.Show("bien");


                }

              

            }
            catch (Exception ex)
            {

                throw ex;
            }



            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = listaturnocliente;

            listaturnocliente.Clear();
            ListaServicio.Clear();
            total = 0;
            CargarGrilla();
            Limpiar();
                

        }

        private void btnSeleccionServicio_Click(object sender, EventArgs e)
        {
            seleccionado = (TipoServicio)cbTipoServicio.SelectedItem;


            ListaServicio.Add(seleccionado);

            txtPrecioServicio.Text = seleccionado.PrecioServicio.ToString();

            total += decimal.Parse(txtPrecioServicio.Text);






        }

        private void btnSeleccionClliente_Click(object sender, EventArgs e)
        {
            SeleccionarIdCliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;



        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
      

            modificarturno = (TurnoListaDto)dgvVerTurno.CurrentRow.DataBoundItem;

             Idturno = modificarturno.IdTurno;

            txtHoraInicio.Text = modificarturno.Inicio.ToString();
            txtHoraFin.Text = modificarturno.Fin.ToString();
            txtNombre.Text = modificarturno.Cliente;
            txtTelefono.Text = modificarturno.Telefono;

            

            EnableTxt();

            VisibleTxt();
            BtnInvisibles();


        }


        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar() 
        {

            txtDni.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtPrecioServicio.Text = "";

            txtDni.Focus();

        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {

            modificarturno = (TurnoListaDto)dgvVerTurno.CurrentRow.DataBoundItem;

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Cancelar el Turno?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    modificarturno.Estado = "Cancelado";
                    turnoNegocio.CancelarTurno(modificarturno);

                }

                MessageBox.Show("Bien");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrilla() ;

            Limpiar();



        }

        private void btnClienteAtendido_Click(object sender, EventArgs e)
        {
            modificarturno = (TurnoListaDto)dgvVerTurno.CurrentRow.DataBoundItem;

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Turno/Cliente Atendido", "Cliente Atendido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    modificarturno.Estado = "Terminado";
                    turnoNegocio.TurnoAtendido(modificarturno);
                    
                    int id = modificarturno.IdTurno;

                }

                MessageBox.Show("Bien");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrilla();

            Limpiar();




        }

        private void btnNoAsistio_Click(object sender, EventArgs e)
        {
            modificarturno = (TurnoListaDto)dgvVerTurno.CurrentRow.DataBoundItem;

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Turno/Cliente Atendido", "Cliente Atendido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    modificarturno.Estado = "No Asistio";
                    turnoNegocio.CancelarTurno(modificarturno);

                    int id = modificarturno.IdTurno;

                }

                MessageBox.Show("Bien");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrilla();

            Limpiar();
        }

        private void EnableTxt()
        {

             txtDni.Enabled = false;
             txtEmail.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;







        }
        private void Txt()
        {

            txtDni.Enabled = true;
            txtEmail.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;

            Limpiar();

        }

        private void VisibleTxt()
        {

            txtHoraFin.Visible = true;
            txtHoraInicio.Visible = true;

            lblModificarHorFIn.Visible = true;
            lblModificarFecha.Visible = true;

            btnModificarDefinitivo.Visible = true;




        }
        private void InvisibleTxt()
        {
            txtHoraFin.Visible = false;
            txtHoraInicio.Visible = false;

            lblModificarHorFIn.Visible = false;
            lblModificarFecha.Visible = false;

            btnModificarDefinitivo.Visible = false;

            lblSinTurno.Visible = false;
        }

        private void btnModificarDefinitivo_Click(object sender, EventArgs e)
        {

                    TurnoNegocio turnoNegocio = new TurnoNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Modificar el Turno?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    modificarturno.IdTurno = Idturno;



                    modificarturno.Inicio = dtpHoraInicioTurno.Value.Date + dtpHoraInicio.Value.TimeOfDay;
                    modificarturno.Fin = dtpHoraFinTurno.Value.Date + dtpHoraFin.Value.TimeOfDay;

                    if (turnoNegocio.TurnoRepetido(modificarturno.Inicio, modificarturno.Fin)) { MessageBox.Show("repetido"); return; }
                    turnoNegocio.ModificarTurno(modificarturno);

                    MessageBox.Show("bien");

                }

               

            }
            catch (Exception ex)
            {

                throw ex;
            }

 

            CargarGrilla();
            InvisibleTxt();
            BtnVisbles();

            Txt();


        }

        private void BtnInvisibles()
        {


            btnModificarTurno.Visible = false;
            btnNoAsistio.Visible=false;
            btnAgregarCliente.Visible=false;
            btnCancelarTurno.Visible=false;
            btnClienteAtendido.Visible=false;
            btnAgregarTurno.Visible = false;
            btnSeleccionClliente.Visible=false;
            btnSeleccionServicio.Visible=false;

            


        }
        private void BtnVisbles()
        {

            btnModificarTurno.Visible = true;
            btnNoAsistio.Visible = true;
            btnAgregarCliente.Visible = true;
            btnCancelarTurno.Visible = true;
            btnClienteAtendido.Visible = true;
            btnAgregarTurno.Visible = true;
            btnSeleccionClliente.Visible = true;
            btnSeleccionServicio.Visible = true;



        }

        private void btnLimpiarFecha_Click(object sender, EventArgs e)
        {
            dtpHoraVerTurnos.Value = DateTime.Today;

            CargarGrilla();

            lblSinTurno.Visible = false;




        }

        private void dgvVerTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
  
              

            

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Modificar los Servicios De Este Turno/Cliente?", "Modificacacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    

                }

                MessageBox.Show("Bien");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrilla();

            Limpiar();




        }

   

        private void ModificarServicio()
        {

            modificarservicio = (TipoServicio)cbTipoServicio.SelectedItem;


            listamodificarservicio.Add(modificarservicio);

            totalmodificadoservcicio += decimal.Parse(txtPrecioServicio.Text);


              Servicio servicio = new Servicio();
            servicio.tipoServicios = listamodificarservicio;    
            servicio.TotalServicio = totalmodificadoservcicio;  

              ClienteTurno clienteTurno = new ClienteTurno();   

             clienteTurno.servicios.Add(servicio);

               listaturnocliente.Add(clienteTurno);

            turno = new Turno();
            turno.clienteTurnos = listaturnocliente;
            
            

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            turnoNegocio.ModificarServicio(turno);

            

         



              



        }
    }
}
           
