namespace SisteaEsteticaBarberia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dtpHoraVerTurnos = new System.Windows.Forms.DateTimePicker();
            this.dgvVerTurno = new System.Windows.Forms.DataGridView();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dtpHoraInicioTurno = new System.Windows.Forms.DateTimePicker();
            this.lblInicioTurno = new System.Windows.Forms.Label();
            this.lblFinTurno = new System.Windows.Forms.Label();
            this.dtpHoraFinTurno = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.lblSinTurno = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionServicio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.lblSignoPeso = new System.Windows.Forms.Label();
            this.btnSeleccionClliente = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.btnClienteAtendido = new System.Windows.Forms.Button();
            this.btnNoAsistio = new System.Windows.Forms.Button();
            this.lblModificarFecha = new System.Windows.Forms.Label();
            this.lblModificarHorFIn = new System.Windows.Forms.Label();
            this.btnModificarDefinitivo = new System.Windows.Forms.Button();
            this.btnLimpiarFecha = new System.Windows.Forms.Button();
            this.btnModificarServicio = new System.Windows.Forms.Button();
            this.btnModificarServicioDefinito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(492, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Turnos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(227, 529);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(92, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Nombre y Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(243, 419);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Dni";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(562, 419);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(562, 525);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(345, 522);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(345, 412);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(666, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(666, 518);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(951, 518);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(179, 23);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dtpHoraVerTurnos
            // 
            this.dtpHoraVerTurnos.Location = new System.Drawing.Point(345, 98);
            this.dtpHoraVerTurnos.Name = "dtpHoraVerTurnos";
            this.dtpHoraVerTurnos.Size = new System.Drawing.Size(252, 20);
            this.dtpHoraVerTurnos.TabIndex = 11;
            this.dtpHoraVerTurnos.ValueChanged += new System.EventHandler(this.dtpHoraVerTurnos_ValueChanged);
            // 
            // dgvVerTurno
            // 
            this.dgvVerTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerTurno.Location = new System.Drawing.Point(199, 139);
            this.dgvVerTurno.Name = "dgvVerTurno";
            this.dgvVerTurno.Size = new System.Drawing.Size(601, 170);
            this.dgvVerTurno.TabIndex = 12;
            this.dgvVerTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerTurno_CellContentClick);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(457, 328);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(81, 13);
            this.lblTurno.TabIndex = 13;
            this.lblTurno.Text = "Habilitar Turnos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(205, 635);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Tipo De Servicio ";
            // 
            // dtpHoraInicioTurno
            // 
            this.dtpHoraInicioTurno.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpHoraInicioTurno.Location = new System.Drawing.Point(554, 675);
            this.dtpHoraInicioTurno.Name = "dtpHoraInicioTurno";
            this.dtpHoraInicioTurno.Size = new System.Drawing.Size(212, 20);
            this.dtpHoraInicioTurno.TabIndex = 16;
            // 
            // lblInicioTurno
            // 
            this.lblInicioTurno.AutoSize = true;
            this.lblInicioTurno.Location = new System.Drawing.Point(562, 635);
            this.lblInicioTurno.Name = "lblInicioTurno";
            this.lblInicioTurno.Size = new System.Drawing.Size(155, 13);
            this.lblInicioTurno.TabIndex = 17;
            this.lblInicioTurno.Text = "Fecha Y hora Del Turno (Inicio)";
            // 
            // lblFinTurno
            // 
            this.lblFinTurno.AutoSize = true;
            this.lblFinTurno.Location = new System.Drawing.Point(1006, 635);
            this.lblFinTurno.Name = "lblFinTurno";
            this.lblFinTurno.Size = new System.Drawing.Size(146, 13);
            this.lblFinTurno.TabIndex = 18;
            this.lblFinTurno.Text = "Fecha Y Hora Del Turno (Fin)";
            // 
            // dtpHoraFinTurno
            // 
            this.dtpHoraFinTurno.Location = new System.Drawing.Point(986, 674);
            this.dtpHoraFinTurno.Name = "dtpHoraFinTurno";
            this.dtpHoraFinTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraFinTurno.TabIndex = 19;
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(1337, 670);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(184, 23);
            this.btnAgregarTurno.TabIndex = 20;
            this.btnAgregarTurno.Text = "Agregar Turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // lblSinTurno
            // 
            this.lblSinTurno.AutoSize = true;
            this.lblSinTurno.Location = new System.Drawing.Point(885, 201);
            this.lblSinTurno.Name = "lblSinTurno";
            this.lblSinTurno.Size = new System.Drawing.Size(35, 13);
            this.lblSinTurno.TabIndex = 22;
            this.lblSinTurno.Text = "label1";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCliente.Location = new System.Drawing.Point(951, 139);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(438, 177);
            this.dgvCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(1142, 48);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 13);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "Clientes";
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(181, 674);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(167, 21);
            this.cbTipoServicio.TabIndex = 25;
            this.cbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoServicio_SelectedIndexChanged);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(797, 675);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(80, 20);
            this.dtpHoraInicio.TabIndex = 26;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(1207, 675);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraFin.TabIndex = 27;
            // 
            // btnSeleccionServicio
            // 
            this.btnSeleccionServicio.Location = new System.Drawing.Point(181, 721);
            this.btnSeleccionServicio.Name = "btnSeleccionServicio";
            this.btnSeleccionServicio.Size = new System.Drawing.Size(167, 23);
            this.btnSeleccionServicio.TabIndex = 28;
            this.btnSeleccionServicio.Text = "Seleccionar Servicio";
            this.btnSeleccionServicio.UseVisualStyleBackColor = true;
            this.btnSeleccionServicio.Click += new System.EventHandler(this.btnSeleccionServicio_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1645, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(418, 639);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 13);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio Del Servicio";
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(421, 674);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(70, 20);
            this.txtPrecioServicio.TabIndex = 31;
            // 
            // lblSignoPeso
            // 
            this.lblSignoPeso.AutoSize = true;
            this.lblSignoPeso.Location = new System.Drawing.Point(391, 680);
            this.lblSignoPeso.Name = "lblSignoPeso";
            this.lblSignoPeso.Size = new System.Drawing.Size(13, 13);
            this.lblSignoPeso.TabIndex = 32;
            this.lblSignoPeso.Text = "$";
            // 
            // btnSeleccionClliente
            // 
            this.btnSeleccionClliente.Location = new System.Drawing.Point(1429, 196);
            this.btnSeleccionClliente.Name = "btnSeleccionClliente";
            this.btnSeleccionClliente.Size = new System.Drawing.Size(204, 23);
            this.btnSeleccionClliente.TabIndex = 33;
            this.btnSeleccionClliente.Text = "Selecione el Cliente Para el Turno";
            this.btnSeleccionClliente.UseVisualStyleBackColor = true;
            this.btnSeleccionClliente.Click += new System.EventHandler(this.btnSeleccionClliente_Click);
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.Location = new System.Drawing.Point(1337, 726);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(184, 23);
            this.btnModificarTurno.TabIndex = 34;
            this.btnModificarTurno.Text = "Modificar Fecha Del Turno";
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarTurno_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(554, 765);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(212, 20);
            this.txtHoraInicio.TabIndex = 35;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(986, 765);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(200, 20);
            this.txtHoraFin.TabIndex = 36;
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Location = new System.Drawing.Point(1337, 765);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(184, 23);
            this.btnCancelarTurno.TabIndex = 37;
            this.btnCancelarTurno.Text = "Cancelar Turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            this.btnCancelarTurno.Click += new System.EventHandler(this.btnCancelarTurno_Click);
            // 
            // btnClienteAtendido
            // 
            this.btnClienteAtendido.Location = new System.Drawing.Point(1337, 818);
            this.btnClienteAtendido.Name = "btnClienteAtendido";
            this.btnClienteAtendido.Size = new System.Drawing.Size(184, 23);
            this.btnClienteAtendido.TabIndex = 38;
            this.btnClienteAtendido.Text = "Cliente Atendido";
            this.btnClienteAtendido.UseVisualStyleBackColor = true;
            this.btnClienteAtendido.Click += new System.EventHandler(this.btnClienteAtendido_Click);
            // 
            // btnNoAsistio
            // 
            this.btnNoAsistio.Location = new System.Drawing.Point(1337, 874);
            this.btnNoAsistio.Name = "btnNoAsistio";
            this.btnNoAsistio.Size = new System.Drawing.Size(184, 23);
            this.btnNoAsistio.TabIndex = 39;
            this.btnNoAsistio.Text = "No Asistio ";
            this.btnNoAsistio.UseVisualStyleBackColor = true;
            this.btnNoAsistio.Click += new System.EventHandler(this.btnNoAsistio_Click);
            // 
            // lblModificarFecha
            // 
            this.lblModificarFecha.AutoSize = true;
            this.lblModificarFecha.Location = new System.Drawing.Point(575, 731);
            this.lblModificarFecha.Name = "lblModificarFecha";
            this.lblModificarFecha.Size = new System.Drawing.Size(166, 13);
            this.lblModificarFecha.TabIndex = 40;
            this.lblModificarFecha.Text = "Fecha y Hora de Inicio (Modificar)";
            // 
            // lblModificarHorFIn
            // 
            this.lblModificarHorFIn.AutoSize = true;
            this.lblModificarHorFIn.Location = new System.Drawing.Point(1006, 727);
            this.lblModificarHorFIn.Name = "lblModificarHorFIn";
            this.lblModificarHorFIn.Size = new System.Drawing.Size(140, 13);
            this.lblModificarHorFIn.TabIndex = 41;
            this.lblModificarHorFIn.Text = "Fecha y Hora Fin (Modificar)";
            // 
            // btnModificarDefinitivo
            // 
            this.btnModificarDefinitivo.Location = new System.Drawing.Point(1337, 765);
            this.btnModificarDefinitivo.Name = "btnModificarDefinitivo";
            this.btnModificarDefinitivo.Size = new System.Drawing.Size(184, 23);
            this.btnModificarDefinitivo.TabIndex = 42;
            this.btnModificarDefinitivo.Text = "Modificar El Turno?";
            this.btnModificarDefinitivo.UseVisualStyleBackColor = true;
            this.btnModificarDefinitivo.Click += new System.EventHandler(this.btnModificarDefinitivo_Click);
            // 
            // btnLimpiarFecha
            // 
            this.btnLimpiarFecha.Location = new System.Drawing.Point(638, 95);
            this.btnLimpiarFecha.Name = "btnLimpiarFecha";
            this.btnLimpiarFecha.Size = new System.Drawing.Size(113, 23);
            this.btnLimpiarFecha.TabIndex = 43;
            this.btnLimpiarFecha.Text = "Limpiar Fecha";
            this.btnLimpiarFecha.UseVisualStyleBackColor = true;
            this.btnLimpiarFecha.Click += new System.EventHandler(this.btnLimpiarFecha_Click);
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.Location = new System.Drawing.Point(1337, 918);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(184, 23);
            this.btnModificarServicio.TabIndex = 44;
            this.btnModificarServicio.Text = "Modificar Servicio Del Cliente";
            this.btnModificarServicio.UseVisualStyleBackColor = true;
            this.btnModificarServicio.Click += new System.EventHandler(this.btnModificarServicio_Click);
            // 
            // btnModificarServicioDefinito
            // 
            this.btnModificarServicioDefinito.Location = new System.Drawing.Point(1337, 958);
            this.btnModificarServicioDefinito.Name = "btnModificarServicioDefinito";
            this.btnModificarServicioDefinito.Size = new System.Drawing.Size(184, 23);
            this.btnModificarServicioDefinito.TabIndex = 45;
            this.btnModificarServicioDefinito.Text = "Modificar servicio?";
            this.btnModificarServicioDefinito.UseVisualStyleBackColor = true;
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 1009);
            this.Controls.Add(this.btnModificarServicioDefinito);
            this.Controls.Add(this.btnModificarServicio);
            this.Controls.Add(this.btnLimpiarFecha);
            this.Controls.Add(this.btnModificarDefinitivo);
            this.Controls.Add(this.lblModificarHorFIn);
            this.Controls.Add(this.lblModificarFecha);
            this.Controls.Add(this.btnNoAsistio);
            this.Controls.Add(this.btnClienteAtendido);
            this.Controls.Add(this.btnCancelarTurno);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.btnModificarTurno);
            this.Controls.Add(this.btnSeleccionClliente);
            this.Controls.Add(this.lblSignoPeso);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnSeleccionServicio);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblSinTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.dtpHoraFinTurno);
            this.Controls.Add(this.lblFinTurno);
            this.Controls.Add(this.lblInicioTurno);
            this.Controls.Add(this.dtpHoraInicioTurno);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.dgvVerTurno);
            this.Controls.Add(this.dtpHoraVerTurnos);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DateTimePicker dtpHoraVerTurnos;
        private System.Windows.Forms.DataGridView dgvVerTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioTurno;
        private System.Windows.Forms.Label lblInicioTurno;
        private System.Windows.Forms.Label lblFinTurno;
        private System.Windows.Forms.DateTimePicker dtpHoraFinTurno;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.Label lblSinTurno;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Button btnSeleccionServicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.Label lblSignoPeso;
        private System.Windows.Forms.Button btnSeleccionClliente;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.Button btnClienteAtendido;
        private System.Windows.Forms.Button btnNoAsistio;
        private System.Windows.Forms.Label lblModificarFecha;
        private System.Windows.Forms.Label lblModificarHorFIn;
        private System.Windows.Forms.Button btnModificarDefinitivo;
        private System.Windows.Forms.Button btnLimpiarFecha;
        private System.Windows.Forms.Button btnModificarServicio;
        private System.Windows.Forms.Button btnModificarServicioDefinito;
    }
}

