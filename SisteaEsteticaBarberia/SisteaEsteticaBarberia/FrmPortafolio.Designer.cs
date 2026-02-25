namespace SisteaEsteticaBarberia
{
    partial class FrmPortafolio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.lblTituloImagen = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnModificarTitulo = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnElegirImagenPc = new System.Windows.Forms.Button();
            this.btnTituloImagen = new System.Windows.Forms.Button();
            this.btnModificarImagen = new System.Windows.Forms.Button();
            this.btnModicarDefinitivoImagen = new System.Windows.Forms.Button();
            this.btnModificarDefinitivoTitulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(369, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Portaflio De Imagenes";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(814, 141);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(178, 23);
            this.btnAgregarImagen.TabIndex = 1;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Location = new System.Drawing.Point(814, 199);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(178, 23);
            this.btnEliminarImagen.TabIndex = 2;
            this.btnEliminarImagen.Text = "Eliminar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            // 
            // dgvImagen
            // 
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(241, 481);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.Size = new System.Drawing.Size(148, 206);
            this.dgvImagen.TabIndex = 3;
            this.dgvImagen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvImagen.SelectionChanged += new System.EventHandler(this.dgvImagen_SelectionChanged);
            // 
            // lblTituloImagen
            // 
            this.lblTituloImagen.AutoSize = true;
            this.lblTituloImagen.Location = new System.Drawing.Point(70, 143);
            this.lblTituloImagen.Name = "lblTituloImagen";
            this.lblTituloImagen.Size = new System.Drawing.Size(178, 13);
            this.lblTituloImagen.TabIndex = 4;
            this.lblTituloImagen.Text = "Titulo De La Imagen (Tipo De Corte)";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(70, 220);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(123, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Coloque Aqui La Imagen";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(317, 144);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(317, 217);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(148, 20);
            this.txtUrlImagen.TabIndex = 7;
            // 
            // btnModificarTitulo
            // 
            this.btnModificarTitulo.Location = new System.Drawing.Point(814, 262);
            this.btnModificarTitulo.Name = "btnModificarTitulo";
            this.btnModificarTitulo.Size = new System.Drawing.Size(178, 23);
            this.btnModificarTitulo.TabIndex = 8;
            this.btnModificarTitulo.Text = "Modificar Titulo De La Imagen";
            this.btnModificarTitulo.UseVisualStyleBackColor = true;
            this.btnModificarTitulo.Click += new System.EventHandler(this.btnModificarTitulo_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(545, 428);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(540, 480);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(70, 435);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(70, 13);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtrar Imagen";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(241, 428);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(148, 20);
            this.txtFiltro.TabIndex = 11;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnElegirImagenPc
            // 
            this.btnElegirImagenPc.Location = new System.Drawing.Point(529, 216);
            this.btnElegirImagenPc.Name = "btnElegirImagenPc";
            this.btnElegirImagenPc.Size = new System.Drawing.Size(144, 23);
            this.btnElegirImagenPc.TabIndex = 12;
            this.btnElegirImagenPc.Text = "Elegir Imagen";
            this.btnElegirImagenPc.UseVisualStyleBackColor = true;
            this.btnElegirImagenPc.Click += new System.EventHandler(this.btnElegirImagenPc_Click);
            // 
            // btnTituloImagen
            // 
            this.btnTituloImagen.Location = new System.Drawing.Point(814, 326);
            this.btnTituloImagen.Name = "btnTituloImagen";
            this.btnTituloImagen.Size = new System.Drawing.Size(178, 23);
            this.btnTituloImagen.TabIndex = 13;
            this.btnTituloImagen.Text = "Modificar Titulo De La Imagen";
            this.btnTituloImagen.UseVisualStyleBackColor = true;
            this.btnTituloImagen.Click += new System.EventHandler(this.btnTituloImagen_Click);
            // 
            // btnModificarImagen
            // 
            this.btnModificarImagen.Location = new System.Drawing.Point(814, 326);
            this.btnModificarImagen.Name = "btnModificarImagen";
            this.btnModificarImagen.Size = new System.Drawing.Size(178, 23);
            this.btnModificarImagen.TabIndex = 14;
            this.btnModificarImagen.Text = "Modificar Imagen";
            this.btnModificarImagen.UseVisualStyleBackColor = true;
            this.btnModificarImagen.Click += new System.EventHandler(this.btnModificarImagen_Click);
            // 
            // btnModicarDefinitivoImagen
            // 
            this.btnModicarDefinitivoImagen.Location = new System.Drawing.Point(1058, 199);
            this.btnModicarDefinitivoImagen.Name = "btnModicarDefinitivoImagen";
            this.btnModicarDefinitivoImagen.Size = new System.Drawing.Size(178, 23);
            this.btnModicarDefinitivoImagen.TabIndex = 15;
            this.btnModicarDefinitivoImagen.Text = "Modificar Imagen?";
            this.btnModicarDefinitivoImagen.UseVisualStyleBackColor = true;
            this.btnModicarDefinitivoImagen.Click += new System.EventHandler(this.btnModicarDefinitivoImagen_Click);
            // 
            // btnModificarDefinitivoTitulo
            // 
            this.btnModificarDefinitivoTitulo.Location = new System.Drawing.Point(1058, 262);
            this.btnModificarDefinitivoTitulo.Name = "btnModificarDefinitivoTitulo";
            this.btnModificarDefinitivoTitulo.Size = new System.Drawing.Size(178, 23);
            this.btnModificarDefinitivoTitulo.TabIndex = 16;
            this.btnModificarDefinitivoTitulo.Text = "Modificar Titulo?";
            this.btnModificarDefinitivoTitulo.UseVisualStyleBackColor = true;
            this.btnModificarDefinitivoTitulo.Click += new System.EventHandler(this.btnModificarDefinitivoTitulo_Click);
            // 
            // FrmPortafolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 937);
            this.Controls.Add(this.btnModificarDefinitivoTitulo);
            this.Controls.Add(this.btnModicarDefinitivoImagen);
            this.Controls.Add(this.btnModificarImagen);
            this.Controls.Add(this.btnTituloImagen);
            this.Controls.Add(this.btnElegirImagenPc);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnModificarTitulo);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblTituloImagen);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPortafolio";
            this.Text = "FrmPortafolio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPortafolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.Label lblTituloImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnModificarTitulo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnElegirImagenPc;
        private System.Windows.Forms.Button btnTituloImagen;
        private System.Windows.Forms.Button btnModificarImagen;
        private System.Windows.Forms.Button btnModicarDefinitivoImagen;
        private System.Windows.Forms.Button btnModificarDefinitivoTitulo;
    }
}