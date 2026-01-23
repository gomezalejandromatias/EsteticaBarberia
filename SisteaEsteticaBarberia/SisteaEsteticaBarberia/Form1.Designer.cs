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
            this.lblDni.Location = new System.Drawing.Point(196, 419);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(92, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Nombre y Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 525);
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
            this.txtNombre.Location = new System.Drawing.Point(329, 412);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(329, 518);
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
            this.btnAgregarCliente.Location = new System.Drawing.Point(914, 515);
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
            this.lblDescripcion.Location = new System.Drawing.Point(196, 590);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Tipo De Servicio ";
            // 
            // dtpHoraInicioTurno
            // 
            this.dtpHoraInicioTurno.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpHoraInicioTurno.Location = new System.Drawing.Point(554, 640);
            this.dtpHoraInicioTurno.Name = "dtpHoraInicioTurno";
            this.dtpHoraInicioTurno.Size = new System.Drawing.Size(212, 20);
            this.dtpHoraInicioTurno.TabIndex = 16;
            // 
            // lblInicioTurno
            // 
            this.lblInicioTurno.AutoSize = true;
            this.lblInicioTurno.Location = new System.Drawing.Point(562, 590);
            this.lblInicioTurno.Name = "lblInicioTurno";
            this.lblInicioTurno.Size = new System.Drawing.Size(155, 13);
            this.lblInicioTurno.TabIndex = 17;
            this.lblInicioTurno.Text = "Fecha Y hora Del Turno (Inicio)";
            // 
            // lblFinTurno
            // 
            this.lblFinTurno.AutoSize = true;
            this.lblFinTurno.Location = new System.Drawing.Point(1014, 590);
            this.lblFinTurno.Name = "lblFinTurno";
            this.lblFinTurno.Size = new System.Drawing.Size(146, 13);
            this.lblFinTurno.TabIndex = 18;
            this.lblFinTurno.Text = "Fecha Y Hora Del Turno (Fin)";
            // 
            // dtpHoraFinTurno
            // 
            this.dtpHoraFinTurno.Location = new System.Drawing.Point(986, 640);
            this.dtpHoraFinTurno.Name = "dtpHoraFinTurno";
            this.dtpHoraFinTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraFinTurno.TabIndex = 19;
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(1337, 639);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(150, 23);
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
            this.dgvCliente.Location = new System.Drawing.Point(951, 139);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(449, 177);
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
            this.cbTipoServicio.Location = new System.Drawing.Point(199, 635);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(167, 21);
            this.cbTipoServicio.TabIndex = 25;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(792, 640);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(80, 20);
            this.dtpHoraInicio.TabIndex = 26;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(1209, 640);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraFin.TabIndex = 27;
            // 
            // btnSeleccionServicio
            // 
            this.btnSeleccionServicio.Location = new System.Drawing.Point(199, 672);
            this.btnSeleccionServicio.Name = "btnSeleccionServicio";
            this.btnSeleccionServicio.Size = new System.Drawing.Size(167, 23);
            this.btnSeleccionServicio.TabIndex = 28;
            this.btnSeleccionServicio.Text = "Seleccionar Servicio";
            this.btnSeleccionServicio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 728);
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
    }
}

