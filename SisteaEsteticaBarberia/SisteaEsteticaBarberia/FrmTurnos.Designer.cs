namespace SisteaEsteticaBarberia
{
    partial class FrmTurnos
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
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnModificarServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.lblTituloServicio = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lblPrecioServicio = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.lblSignoPlata = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(73, 119);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(626, 254);
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
            this.dtpElegirFcehaTurno.Location = new System.Drawing.Point(720, 144);
            this.dtpElegirFcehaTurno.Name = "dtpElegirFcehaTurno";
            this.dtpElegirFcehaTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpElegirFcehaTurno.TabIndex = 2;
            // 
            // btnSeleccionarTurno
            // 
            this.btnSeleccionarTurno.Location = new System.Drawing.Point(720, 206);
            this.btnSeleccionarTurno.Name = "btnSeleccionarTurno";
            this.btnSeleccionarTurno.Size = new System.Drawing.Size(200, 23);
            this.btnSeleccionarTurno.TabIndex = 3;
            this.btnSeleccionarTurno.Text = "Seleccione la Fecha Del Turno";
            this.btnSeleccionarTurno.UseVisualStyleBackColor = true;
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.Location = new System.Drawing.Point(720, 281);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(200, 23);
            this.btnModificarTurno.TabIndex = 4;
            this.btnModificarTurno.Text = "ModificarTurno";
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(720, 350);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(200, 23);
            this.btnEliminarTurno.TabIndex = 5;
            this.btnEliminarTurno.Text = "Eliminar Turno";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.Location = new System.Drawing.Point(345, 495);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(152, 23);
            this.btnModificarServicio.TabIndex = 6;
            this.btnModificarServicio.Text = "Modificar Servicio";
            this.btnModificarServicio.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Location = new System.Drawing.Point(345, 561);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(152, 23);
            this.btnEliminarServicio.TabIndex = 7;
            this.btnEliminarServicio.Text = "Eliminar Servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            // 
            // lblTituloServicio
            // 
            this.lblTituloServicio.AutoSize = true;
            this.lblTituloServicio.Location = new System.Drawing.Point(323, 405);
            this.lblTituloServicio.Name = "lblTituloServicio";
            this.lblTituloServicio.Size = new System.Drawing.Size(50, 13);
            this.lblTituloServicio.TabIndex = 8;
            this.lblTituloServicio.Text = "Servicios";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(720, 493);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(200, 20);
            this.txtNombreServicio.TabIndex = 10;
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(720, 569);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioServicio.TabIndex = 11;
            this.txtPrecioServicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Location = new System.Drawing.Point(73, 479);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.Size = new System.Drawing.Size(240, 242);
            this.dgvTipoServicio.TabIndex = 12;
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Location = new System.Drawing.Point(561, 500);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(104, 13);
            this.lblNombreServicio.TabIndex = 13;
            this.lblNombreServicio.Text = "Nombre Del Servicio";
            // 
            // lblPrecioServicio
            // 
            this.lblPrecioServicio.AutoSize = true;
            this.lblPrecioServicio.Location = new System.Drawing.Point(568, 571);
            this.lblPrecioServicio.Name = "lblPrecioServicio";
            this.lblPrecioServicio.Size = new System.Drawing.Size(97, 13);
            this.lblPrecioServicio.TabIndex = 14;
            this.lblPrecioServicio.Text = "Precio Del Servicio";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(996, 571);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(146, 25);
            this.btnAgregarServicio.TabIndex = 15;
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // lblSignoPlata
            // 
            this.lblSignoPlata.AutoSize = true;
            this.lblSignoPlata.Location = new System.Drawing.Point(679, 571);
            this.lblSignoPlata.Name = "lblSignoPlata";
            this.lblSignoPlata.Size = new System.Drawing.Size(13, 13);
            this.lblSignoPlata.TabIndex = 16;
            this.lblSignoPlata.Text = "$";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 781);
            this.Controls.Add(this.lblSignoPlata);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.lblPrecioServicio);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.lblTituloServicio);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnModificarServicio);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnModificarTurno);
            this.Controls.Add(this.btnSeleccionarTurno);
            this.Controls.Add(this.dtpElegirFcehaTurno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTurnos";
            this.Text = "FrmTurnos";
            this.Load += new System.EventHandler(this.FrmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpElegirFcehaTurno;
        private System.Windows.Forms.Button btnSeleccionarTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnModificarServicio;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Label lblTituloServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Label lblPrecioServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Label lblSignoPlata;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}