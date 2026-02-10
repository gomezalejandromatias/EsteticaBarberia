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
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpElegirFcehaTurno = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionarTurno = new System.Windows.Forms.Button();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(39, 119);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(822, 232);
            this.dgvTurnos.TabIndex = 0;
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
            // dtpElegirFcehaTurno
            // 
            this.dtpElegirFcehaTurno.Location = new System.Drawing.Point(936, 162);
            this.dtpElegirFcehaTurno.Name = "dtpElegirFcehaTurno";
            this.dtpElegirFcehaTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpElegirFcehaTurno.TabIndex = 2;
            // 
            // btnSeleccionarTurno
            // 
            this.btnSeleccionarTurno.Location = new System.Drawing.Point(936, 279);
            this.btnSeleccionarTurno.Name = "btnSeleccionarTurno";
            this.btnSeleccionarTurno.Size = new System.Drawing.Size(200, 23);
            this.btnSeleccionarTurno.TabIndex = 3;
            this.btnSeleccionarTurno.Text = "Seleccione la Fecha Del Turno";
            this.btnSeleccionarTurno.UseVisualStyleBackColor = true;
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Location = new System.Drawing.Point(39, 403);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.Size = new System.Drawing.Size(822, 241);
            this.dgvTipoServicio.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 734);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 246);
            this.dataGridView1.TabIndex = 18;
            // 
            // FrmHistorialTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 1061);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.btnSeleccionarTurno);
            this.Controls.Add(this.dtpElegirFcehaTurno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHistorialTurnos";
            this.Text = "FrmHistorialTurnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpElegirFcehaTurno;
        private System.Windows.Forms.Button btnSeleccionarTurno;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}