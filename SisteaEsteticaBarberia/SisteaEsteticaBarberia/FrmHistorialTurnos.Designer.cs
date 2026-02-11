namespace SisteaEsteticaBarberia
{
    partial class FrmHistorialTurnos
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
            this.dgvTurnosTerminados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpElegirFechaTurnoTerminado = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionarTurno = new System.Windows.Forms.Button();
            this.dgvNoAsistio = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvCancelado = new System.Windows.Forms.DataGridView();
            this.dtpFechaNoAsistio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTurnoCancelado = new System.Windows.Forms.DateTimePicker();
            this.btnCancelado = new System.Windows.Forms.Button();
            this.btnNoAsistio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosTerminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsistio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnosTerminados
            // 
            this.dgvTurnosTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosTerminados.Location = new System.Drawing.Point(39, 119);
            this.dgvTurnosTerminados.Name = "dgvTurnosTerminados";
            this.dgvTurnosTerminados.Size = new System.Drawing.Size(822, 232);
            this.dgvTurnosTerminados.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(267, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(77, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Turnos del dia ";
            // 
            // dtpElegirFechaTurnoTerminado
            // 
            this.dtpElegirFechaTurnoTerminado.Location = new System.Drawing.Point(936, 162);
            this.dtpElegirFechaTurnoTerminado.Name = "dtpElegirFechaTurnoTerminado";
            this.dtpElegirFechaTurnoTerminado.Size = new System.Drawing.Size(200, 20);
            this.dtpElegirFechaTurnoTerminado.TabIndex = 2;
            // 
            // btnSeleccionarTurno
            // 
            this.btnSeleccionarTurno.Location = new System.Drawing.Point(936, 279);
            this.btnSeleccionarTurno.Name = "btnSeleccionarTurno";
            this.btnSeleccionarTurno.Size = new System.Drawing.Size(200, 23);
            this.btnSeleccionarTurno.TabIndex = 3;
            this.btnSeleccionarTurno.Text = "Seleccione la Fecha Del Turno";
            this.btnSeleccionarTurno.UseVisualStyleBackColor = true;
            this.btnSeleccionarTurno.Click += new System.EventHandler(this.btnSeleccionarTurno_Click);
            // 
            // dgvNoAsistio
            // 
            this.dgvNoAsistio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoAsistio.Location = new System.Drawing.Point(39, 403);
            this.dgvNoAsistio.Name = "dgvNoAsistio";
            this.dgvNoAsistio.Size = new System.Drawing.Size(822, 241);
            this.dgvNoAsistio.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvCancelado
            // 
            this.dgvCancelado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelado.Location = new System.Drawing.Point(39, 734);
            this.dgvCancelado.Name = "dgvCancelado";
            this.dgvCancelado.Size = new System.Drawing.Size(835, 246);
            this.dgvCancelado.TabIndex = 18;
            // 
            // dtpFechaNoAsistio
            // 
            this.dtpFechaNoAsistio.Location = new System.Drawing.Point(936, 464);
            this.dtpFechaNoAsistio.Name = "dtpFechaNoAsistio";
            this.dtpFechaNoAsistio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNoAsistio.TabIndex = 19;
            // 
            // dtpFechaTurnoCancelado
            // 
            this.dtpFechaTurnoCancelado.Location = new System.Drawing.Point(936, 781);
            this.dtpFechaTurnoCancelado.Name = "dtpFechaTurnoCancelado";
            this.dtpFechaTurnoCancelado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTurnoCancelado.TabIndex = 20;
            // 
            // btnCancelado
            // 
            this.btnCancelado.Location = new System.Drawing.Point(936, 881);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(200, 23);
            this.btnCancelado.TabIndex = 21;
            this.btnCancelado.Text = "Seleccione la Fecha Del Turno";
            this.btnCancelado.UseVisualStyleBackColor = true;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // btnNoAsistio
            // 
            this.btnNoAsistio.Location = new System.Drawing.Point(936, 553);
            this.btnNoAsistio.Name = "btnNoAsistio";
            this.btnNoAsistio.Size = new System.Drawing.Size(200, 23);
            this.btnNoAsistio.TabIndex = 22;
            this.btnNoAsistio.Text = "Seleccione la Fecha Del Turno";
            this.btnNoAsistio.UseVisualStyleBackColor = true;
            this.btnNoAsistio.Click += new System.EventHandler(this.btnNoAsistio_Click);
            // 
            // FrmHistorialTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 1061);
            this.Controls.Add(this.btnNoAsistio);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.dtpFechaTurnoCancelado);
            this.Controls.Add(this.dtpFechaNoAsistio);
            this.Controls.Add(this.dgvCancelado);
            this.Controls.Add(this.dgvNoAsistio);
            this.Controls.Add(this.btnSeleccionarTurno);
            this.Controls.Add(this.dtpElegirFechaTurnoTerminado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvTurnosTerminados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHistorialTurnos";
            this.Text = "FrmHistorialTurnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistorialTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosTerminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsistio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosTerminados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpElegirFechaTurnoTerminado;
        private System.Windows.Forms.Button btnSeleccionarTurno;
        private System.Windows.Forms.DataGridView dgvNoAsistio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvCancelado;
        private System.Windows.Forms.DateTimePicker dtpFechaNoAsistio;
        private System.Windows.Forms.DateTimePicker dtpFechaTurnoCancelado;
        private System.Windows.Forms.Button btnCancelado;
        private System.Windows.Forms.Button btnNoAsistio;
    }
}