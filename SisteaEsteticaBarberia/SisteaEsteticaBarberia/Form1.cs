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
        Cliente ModificarCliente;
        int Idturno = 0;
        int idcliente = 0;
        public List<Turno> turnos = new List<Turno>();

         public Turno turno;

        public Cliente Cliente;
        public Cliente SeleccionarIdCliente;

        public TipoServicio seleccionado;
        public List<TipoServicio> ListaServicio = new List<TipoServicio>();

        public List<TipoServicio>listamodificarservicio = new List<TipoServicio>();

        decimal totalmodificadoservcicio = 0;

        public TurnoListaDto modificarservicio;

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

            btnModificarServicioDefinito.Visible = false;
            btnModificarClieneDefinitivamente.Visible = false;

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
                        IdCliente = ct.Cliente.IdCliente,
                        Cliente = ct.Cliente.Nombre,
                        Telefono = ct.Cliente.Telefono,
                        Servicios = serviciosTexto,
                        Total = total
                    });
                }
            }

            dgvVerTurno.DataSource = null;
            dgvVerTurno.DataSource = grilla;
            dgvVerTurno.ClearSelection();
            dgvVerTurno.CurrentCell = null;



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
            try
            {
                // =========================
                // VALIDACIONES
                // =========================
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el Nombre.");
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Ingrese el DNI.");
                    txtDni.Focus();
                    return;
                }

                // Validación simple de DNI numérico (si lo querés así)
                long dniNumero;
                if (long.TryParse(txtDni.Text.Trim(), out dniNumero) == false)
                {
                    MessageBox.Show("El DNI debe ser numérico.");
                    txtDni.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Ingrese el Teléfono.");
                    txtTelefono.Focus();
                    return;
                }

                // Email opcional: si lo llenó, que tenga formato básico
                if (string.IsNullOrWhiteSpace(txtEmail.Text) == false)
                {
                    if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".") == false)
                    {
                        MessageBox.Show("Ingrese un Email válido.");
                        txtEmail.Focus();
                        return;
                    }
                }

                // =========================
                // GUARDAR
                // =========================
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                Cliente = new Cliente();

                Cliente.Nombre = txtNombre.Text.Trim();
                Cliente.Dni = txtDni.Text.Trim();          // ✅ CORREGIDO
                Cliente.Email = txtEmail.Text.Trim();
                Cliente.Telefono = txtTelefono.Text.Trim();

                clienteNegocio.AgregarCliente(Cliente);

                MessageBox.Show("Cliente Agregado Con Éxito");

                Limpiar();
                CargarGrillaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Si querés relanzar sin perder stack trace:
                // throw;
            }
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
                // =========================
                // VALIDACIONES BÁSICAS
                // =========================
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Ingrese el DNI.");
                    txtDni.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el Nombre.");
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Ingrese el Teléfono.");
                    txtTelefono.Focus();
                    return;
                }

                // Si querés email opcional, no lo valides. Si lo querés obligatorio:
                // if (string.IsNullOrWhiteSpace(txtEmail.Text)) { ... }

                if (ListaServicio == null || ListaServicio.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un servicio.");
                    return;
                }

                if (total <= 0)
                {
                    MessageBox.Show("El total del servicio no puede ser 0.");
                    return;
                }

                if (SeleccionarIdCliente == null || SeleccionarIdCliente.IdCliente <= 0)
                {
                    MessageBox.Show("Seleccione un cliente válido.");
                    return;
                }

                // =========================
                // ARMAR FECHAS
                // =========================
                DateTime inicio = dtpHoraInicioTurno.Value.Date + dtpHoraInicio.Value.TimeOfDay;
                DateTime fin = dtpHoraFinTurno.Value.Date + dtpHoraFin.Value.TimeOfDay;

                if (fin <= inicio)
                {
                    MessageBox.Show("La hora de fin debe ser mayor a la hora de inicio.");
                    return;
                }

                // =========================
                // CONFIRMACIÓN
                // =========================
                DialogResult respuesta = MessageBox.Show(
                    "Desea Agregar el Turno?",
                    "Agregar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta != DialogResult.Yes) return;

                TurnoNegocio turnoNegocio = new TurnoNegocio();

                // =========================
                // VALIDAR TURNO REPETIDO
                // =========================
                if (turnoNegocio.TurnoRepetido(inicio, fin))
                {
                    MessageBox.Show("No se puede: ya existe un turno en ese horario.");
                    return;
                }

                // =========================
                // ARMAR OBJETOS (EVITAR NULL)
                // =========================
                ClienteTurno = new ClienteTurno();

                // IMPORTANTE: asegurar que existan los objetos internos
                if (ClienteTurno.Cliente == null) ClienteTurno.Cliente = new Cliente();
                if (ClienteTurno.servicios == null) ClienteTurno.servicios = new List<Servicio>();
                if (ClienteTurno.Turno == null) ClienteTurno.Turno = new Turno();

                Servicio nuevo = new Servicio();
                nuevo.tipoServicios = new List<TipoServicio>(ListaServicio);
                nuevo.TotalServicio = total;

                // Cliente
                ClienteTurno.Cliente.Dni = txtDni.Text.Trim();
                ClienteTurno.Cliente.Nombre = txtNombre.Text.Trim();
                ClienteTurno.Cliente.Email = txtEmail.Text.Trim();
                ClienteTurno.Cliente.Telefono = txtTelefono.Text.Trim();
                ClienteTurno.Cliente.IdCliente = SeleccionarIdCliente.IdCliente;

                // Servicio
                ClienteTurno.servicios.Add(nuevo);

                // Turno (dentro de ClienteTurno)
                ClienteTurno.Turno.Inicio = inicio;
                ClienteTurno.Turno.Fin = fin;

                // =========================
                // LISTA CLIENTE/TURNO
                // =========================
                // importante aca vacio la lista para qu en el segundo clik
                // la lista no quede con el clinete/turno anterior
                listaturnocliente.Clear();
                listaturnocliente.Add(ClienteTurno);

                // Turno principal
                turno = new Turno();
                turno.clienteTurnos = listaturnocliente;
                turno.Inicio = inicio;
                turno.Fin = fin;
                turno.Estado = "Confirmado";

                // Guardar
                turnoNegocio.AgregarTurno(turno);

                MessageBox.Show("Turno agregado correctamente.");

                // =========================
                // REFRESCAR / LIMPIAR
                // =========================
                dgvVerTurno.DataSource = null;
                dgvVerTurno.DataSource = listaturnocliente;

                listaturnocliente.Clear();
                ListaServicio.Clear();
                total = 0;

                CargarGrilla();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Si querés relanzar sin perder stack trace:
                // throw;
            }


        }

        private void btnSeleccionServicio_Click(object sender, EventArgs e)
        {
            seleccionado = (TipoServicio)cbTipoServicio.SelectedItem;

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccioná un servicio.");
                return;
            }

            decimal precio = seleccionado.PrecioServicio;
            txtPrecioServicio.Text = precio.ToString();

            // 🔵 MODO MODIFICAR
            if (modificarservicio != null)
            {
                listamodificarservicio.Add(seleccionado);
                totalmodificadoservcicio += precio;

                return; // 👉 termina acá este click, no ejecuta lo de crear
            }

            // 🟢 MODO CREAR
            ListaServicio.Add(seleccionado);
            total += precio;


        }

        private void btnSeleccionClliente_Click(object sender, EventArgs e)
        {
            SeleccionarIdCliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;



        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {


            if (dgvVerTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un turno primero.");
                return;
            }

             modificarturno =
                (TurnoListaDto)dgvVerTurno.SelectedRows[0].DataBoundItem;

            if (modificarturno == null)
            {
                MessageBox.Show("Error al obtener el turno.");
                return;
            }
            if (modificarturno.Estado == "Terminado")
            {
                MessageBox.Show("El Turno Figura Como Terminado,No Se Puede Modificar");

                return;


            }

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

            if (dgvVerTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un turno primero.");
                return;
            }

            TurnoListaDto modificarturno =
                (TurnoListaDto)dgvVerTurno.SelectedRows[0].DataBoundItem;

            if (modificarturno == null)
            {
                MessageBox.Show("Error al obtener el turno.");
                return;
            }

            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Cancelar el Turno?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    modificarturno.Estado = "Cancelado";
                    turnoNegocio.CancelarTurno(modificarturno);

                     MessageBox.Show("Bien");
                }


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
            if (dgvVerTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un turno primero.");
                return;
            }

            TurnoListaDto modificarturno =
                (TurnoListaDto)dgvVerTurno.SelectedRows[0].DataBoundItem;

            if (modificarturno == null)
            {
                MessageBox.Show("Error al obtener el turno.");
                return;
            }
            DateTime ahora = DateTime.Now;

            // Si todavía no llegó la hora de inicio, no puede estar atendido
            if (ahora < modificarturno.Inicio)
            {
                MessageBox.Show("No se puede marcar como atendido antes del horario de inicio del turno.");
                return;
            }


            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Turno/Cliente Atendido", "Cliente Atendido?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            if (dgvVerTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un turno primero.");
                return;
            }

            TurnoListaDto modificarturno =
                (TurnoListaDto)dgvVerTurno.SelectedRows[0].DataBoundItem;

            if (modificarturno == null)
            {
                MessageBox.Show("Error al obtener el turno.");
                return;
            }


            TurnoNegocio turnoNegocio = new TurnoNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Turno/Cliente No Asistio", "Cliente No Asistio?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

            // =========================
            // VALIDACIONES
            // =========================

            if (modificarturno == null)
            {
                MessageBox.Show("Seleccione un turno primero.");
                return;
            }

            if (Idturno <= 0)
            {
                MessageBox.Show("Id de turno inválido.");
                return;
            }
           

            DateTime inicio = dtpHoraInicioTurno.Value.Date + dtpHoraInicio.Value.TimeOfDay;
            DateTime fin = dtpHoraFinTurno.Value.Date + dtpHoraFin.Value.TimeOfDay;

            if (fin <= inicio)
            {
                MessageBox.Show("La hora de fin debe ser mayor a la de inicio.");
                return;
            }


        

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "Desea Modificar el Turno?",
                    "Modificacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
          

                if (respuesta != DialogResult.Yes)
                    return;

                modificarturno.IdTurno = Idturno;
                modificarturno.Inicio = inicio;
                modificarturno.Fin = fin;

                // Validar repetido EXCLUYENDO el mismo turno (idealmente tu método debería recibir Id)
                if (turnoNegocio.TurnoRepetido(inicio, fin))
                {
                    MessageBox.Show("Ya existe un turno en ese horario.");
                    return;
                }

                turnoNegocio.ModificarTurno(modificarturno);

                MessageBox.Show("Turno modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
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

            btnModificarServicio.Visible = false;





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


            if (dgvVerTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un turno primero.");
                return;
            }

            modificarservicio =
                (TurnoListaDto)dgvVerTurno.SelectedRows[0].DataBoundItem;

            if (modificarturno == null)
            {
                MessageBox.Show("Error al obtener el turno.");
                return;
            }


            Idturno = modificarservicio.IdTurno;

            idcliente = modificarservicio.IdCliente;

            btnModificarServicioDefinito.Visible = true;

            

        }

   

  

        private void btnModificarServicioDefinito_Click(object sender, EventArgs e)
        {


            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Modificar los Servicios De Este Turno/Cliente?", "Modificacacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    ModificarServicio();

                }

                MessageBox.Show("Servicios Modificados Correctamente");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            CargarGrilla();

            Limpiar();

            btnModificarServicioDefinito.Visible=false;
            
        }

        private void ModificarServicio()
        {




            // =========================
            // VALIDACIONES
            // =========================

            if (idcliente <= 0)
            {
                MessageBox.Show("Cliente inválido.");
                return;
            }

            if (Idturno <= 0)
            {
                MessageBox.Show("Turno inválido.");
                return;
            }

            if (listamodificarservicio == null || listamodificarservicio.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un servicio para modificar.");
                return;
            }

            if (totalmodificadoservcicio <= 0)
            {
                MessageBox.Show("El total no puede ser 0.");
                return;
            }

            // (Opcional) Evitar servicios repetidos por Id
            for (int i = 0; i < listamodificarservicio.Count; i++)
            {
                if (listamodificarservicio[i] == null)
                {
                    MessageBox.Show("Hay un servicio inválido en la lista.");
                    return;
                }
            }

            // =========================
            // ARMAR OBJETOS (EVITAR NULL)
            // =========================

            Servicio servicio = new Servicio();
            servicio.tipoServicios = listamodificarservicio;
            servicio.TotalServicio = totalmodificadoservcicio;

            ClienteTurno clienteTurno = new ClienteTurno();

            // IMPORTANTE: inicializar Cliente y Turno si son null
            if (clienteTurno.Cliente == null) clienteTurno.Cliente = new Cliente();
            if (clienteTurno.Turno == null) clienteTurno.Turno = new Turno();

            clienteTurno.Cliente.IdCliente = idcliente;
            clienteTurno.Turno.IdTurno = Idturno;

            clienteTurno.servicios = new List<Servicio>();
            clienteTurno.servicios.Add(servicio);

            Turno turno = new Turno();
            turno.clienteTurnos = new List<ClienteTurno>();
            turno.clienteTurnos.Add(clienteTurno);

            // =========================
            // EJECUTAR
            // =========================
            try
            {
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                turnoNegocio.ModificarServicio(turno);

                MessageBox.Show("Servicios modificados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }











        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            btnModificarClieneDefinitivamente.Visible = true;

            ModificarCliente = (Cliente)dgvCliente.SelectedRows[0].DataBoundItem;

            if (ModificarCliente == null)
            {
                MessageBox.Show("No se pudo obtener el cliente.");
                return;
            }

            txtDni.Text = ModificarCliente.Dni;
            txtEmail.Text = ModificarCliente.Email;
            txtNombre.Text = ModificarCliente.Nombre;
            txtTelefono.Text = ModificarCliente.Telefono;

            btnAgregarCliente.Visible = false;


        }

        private void btnModificarClieneDefinitivamente_Click(object sender, EventArgs e)
        {



            // Validación: tiene que existir el cliente seleccionado a modificar
            if (ModificarCliente == null)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            // Validaciones de formulario
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingrese el DNI.");
                txtDni.Focus();
                return;
            }

            long dniNumero;
            if (long.TryParse(txtDni.Text.Trim(), out dniNumero) == false)
            {
                MessageBox.Show("El DNI debe ser numérico.");
                txtDni.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el Teléfono.");
                txtTelefono.Focus();
                return;
            }

            // Email opcional: si está cargado, validar básico
            if (string.IsNullOrWhiteSpace(txtEmail.Text) == false)
            {
                if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".") == false)
                {
                    MessageBox.Show("Ingrese un Email válido.");
                    txtEmail.Focus();
                    return;
                }
            }

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea modificar este cliente?",
                    "Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    // Pasar del form al objeto
                    ModificarCliente.Dni = txtDni.Text.Trim();
                    ModificarCliente.Email = txtEmail.Text.Trim();
                    ModificarCliente.Nombre = txtNombre.Text.Trim();
                    ModificarCliente.Telefono = txtTelefono.Text.Trim();

                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteNegocio.ModificarCliente(ModificarCliente);

                    MessageBox.Show("Bien");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            // Volver a modo normal
            btnAgregarCliente.Visible = true;
            btnModificarClieneDefinitivamente.Visible = false;

            txtDni.Focus();

            CargarGrillaCliente();
            Limpiar(); // recomendado


        }

        private void portafolioDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPortafolio form = new FrmPortafolio();
            form.Owner = this;
            form.Show();
            this.Hide();
        }
    }
}
           
