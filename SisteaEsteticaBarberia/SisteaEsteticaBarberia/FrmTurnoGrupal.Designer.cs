namespace SisteaEsteticaBarberia
{
    partial class FrmTurnoGrupal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblTituloTurno = new System.Windows.Forms.Label();
            this.lblTiituloCliente = new System.Windows.Forms.Label();
            this.cbmServicio = new System.Windows.Forms.ComboBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.btnAgregarServico = new System.Windows.Forms.Button();
            this.dtpFechaTurnoInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTurnoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblTituloTurnoInicio = new System.Windows.Forms.Label();
            this.lblTituloTurnoFin = new System.Windows.Forms.Label();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.btnAgregarClienteTurno = new System.Windows.Forms.Button();
            this.lwCliente = new System.Windows.Forms.ListView();
            this.lblTituloListView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurno
            // 
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Location = new System.Drawing.Point(45, 141);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.Size = new System.Drawing.Size(452, 190);
            this.dgvTurno.TabIndex = 0;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(779, 141);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(450, 190);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // lblTituloTurno
            // 
            this.lblTituloTurno.AutoSize = true;
            this.lblTituloTurno.Location = new System.Drawing.Point(213, 71);
            this.lblTituloTurno.Name = "lblTituloTurno";
            this.lblTituloTurno.Size = new System.Drawing.Size(85, 13);
            this.lblTituloTurno.TabIndex = 2;
            this.lblTituloTurno.Text = "Turnos Grupales";
            // 
            // lblTiituloCliente
            // 
            this.lblTiituloCliente.AutoSize = true;
            this.lblTiituloCliente.Location = new System.Drawing.Point(912, 96);
            this.lblTiituloCliente.Name = "lblTiituloCliente";
            this.lblTiituloCliente.Size = new System.Drawing.Size(44, 13);
            this.lblTiituloCliente.TabIndex = 3;
            this.lblTiituloCliente.Text = "Clientes";
            // 
            // cbmServicio
            // 
            this.cbmServicio.FormattingEnabled = true;
            this.cbmServicio.Location = new System.Drawing.Point(45, 445);
            this.cbmServicio.Name = "cbmServicio";
            this.cbmServicio.Size = new System.Drawing.Size(121, 21);
            this.cbmServicio.TabIndex = 4;
            this.cbmServicio.SelectedIndexChanged += new System.EventHandler(this.cbmServicio_SelectedIndexChanged);
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(292, 446);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 20);
            this.txtServicio.TabIndex = 5;
            this.txtServicio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregarServico
            // 
            this.btnAgregarServico.Location = new System.Drawing.Point(45, 520);
            this.btnAgregarServico.Name = "btnAgregarServico";
            this.btnAgregarServico.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarServico.TabIndex = 6;
            this.btnAgregarServico.Text = "Agregar Servicios";
            this.btnAgregarServico.UseVisualStyleBackColor = true;
            this.btnAgregarServico.Click += new System.EventHandler(this.btnAgregarServico_Click);
            // 
            // dtpFechaTurnoInicio
            // 
            this.dtpFechaTurnoInicio.Location = new System.Drawing.Point(580, 446);
            this.dtpFechaTurnoInicio.Name = "dtpFechaTurnoInicio";
            this.dtpFechaTurnoInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTurnoInicio.TabIndex = 7;
            // 
            // dtpFechaTurnoFin
            // 
            this.dtpFechaTurnoFin.Location = new System.Drawing.Point(933, 446);
            this.dtpFechaTurnoFin.Name = "dtpFechaTurnoFin";
            this.dtpFechaTurnoFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTurnoFin.TabIndex = 8;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(804, 446);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(84, 20);
            this.dtpHoraInicio.TabIndex = 9;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(1152, 445);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(90, 20);
            this.dtpHoraFin.TabIndex = 10;
            // 
            // lblTituloTurnoInicio
            // 
            this.lblTituloTurnoInicio.AutoSize = true;
            this.lblTituloTurnoInicio.Location = new System.Drawing.Point(626, 410);
            this.lblTituloTurnoInicio.Name = "lblTituloTurnoInicio";
            this.lblTituloTurnoInicio.Size = new System.Drawing.Size(121, 13);
            this.lblTituloTurnoInicio.TabIndex = 11;
            this.lblTituloTurnoInicio.Text = "Fecha Del Turno (Inicio)";
            // 
            // lblTituloTurnoFin
            // 
            this.lblTituloTurnoFin.AutoSize = true;
            this.lblTituloTurnoFin.Location = new System.Drawing.Point(998, 410);
            this.lblTituloTurnoFin.Name = "lblTituloTurnoFin";
            this.lblTituloTurnoFin.Size = new System.Drawing.Size(110, 13);
            this.lblTituloTurnoFin.TabIndex = 12;
            this.lblTituloTurnoFin.Text = "Fecha Del Turno (Fin)";
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(1308, 447);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(164, 23);
            this.btnAgregarTurno.TabIndex = 13;
            this.btnAgregarTurno.Text = "Agregar Turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // btnAgregarClienteTurno
            // 
            this.btnAgregarClienteTurno.Location = new System.Drawing.Point(1271, 154);
            this.btnAgregarClienteTurno.Name = "btnAgregarClienteTurno";
            this.btnAgregarClienteTurno.Size = new System.Drawing.Size(185, 23);
            this.btnAgregarClienteTurno.TabIndex = 14;
            this.btnAgregarClienteTurno.Text = "Agregar Cliente Turno";
            this.btnAgregarClienteTurno.UseVisualStyleBackColor = true;
            this.btnAgregarClienteTurno.Click += new System.EventHandler(this.btnAgregarClienteTurno_Click);
            // 
            // lwCliente
            // 
            this.lwCliente.HideSelection = false;
            this.lwCliente.Location = new System.Drawing.Point(1259, 234);
            this.lwCliente.Name = "lwCliente";
            this.lwCliente.Size = new System.Drawing.Size(232, 97);
            this.lwCliente.TabIndex = 15;
            this.lwCliente.UseCompatibleStateImageBehavior = false;
            this.lwCliente.SelectedIndexChanged += new System.EventHandler(this.lwCliente_SelectedIndexChanged);
            // 
            // lblTituloListView
            // 
            this.lblTituloListView.AutoSize = true;
            this.lblTituloListView.Location = new System.Drawing.Point(1287, 208);
            this.lblTituloListView.Name = "lblTituloListView";
            this.lblTituloListView.Size = new System.Drawing.Size(94, 13);
            this.lblTituloListView.TabIndex = 16;
            this.lblTituloListView.Text = "Clientes Del Turno";
            // 
            // FrmTurnoGrupal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 637);
            this.Controls.Add(this.lblTituloListView);
            this.Controls.Add(this.lwCliente);
            this.Controls.Add(this.btnAgregarClienteTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.lblTituloTurnoFin);
            this.Controls.Add(this.lblTituloTurnoInicio);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechaTurnoFin);
            this.Controls.Add(this.dtpFechaTurnoInicio);
            this.Controls.Add(this.btnAgregarServico);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.cbmServicio);
            this.Controls.Add(this.lblTiituloCliente);
            this.Controls.Add(this.lblTituloTurno);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.dgvTurno);
            this.Name = "FrmTurnoGrupal";
            this.Text = "FrmTurnoGrupal";
            this.Load += new System.EventHandler(this.FrmTurnoGrupal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblTituloTurno;
        private System.Windows.Forms.Label lblTiituloCliente;
        private System.Windows.Forms.ComboBox cbmServicio;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Button btnAgregarServico;
        private System.Windows.Forms.DateTimePicker dtpFechaTurnoInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaTurnoFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblTituloTurnoInicio;
        private System.Windows.Forms.Label lblTituloTurnoFin;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.Button btnAgregarClienteTurno;
        private System.Windows.Forms.ListView lwCliente;
        private System.Windows.Forms.Label lblTituloListView;
    }
}