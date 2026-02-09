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
            this.button2 = new System.Windows.Forms.Button();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.lblTituloImagen = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
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
            this.btnAgregarImagen.Location = new System.Drawing.Point(545, 184);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(110, 23);
            this.btnAgregarImagen.TabIndex = 1;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.lblTituloImagen.Size = new System.Drawing.Size(103, 13);
            this.lblTituloImagen.TabIndex = 4;
            this.lblTituloImagen.Text = "Titulo De La Imagen";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(70, 220);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(90, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Url De La Imagen";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(241, 143);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(241, 217);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(148, 20);
            this.txtUrlImagen.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(845, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(545, 377);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(710, 310);
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
            // FrmPortafolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 743);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblTituloImagen);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPortafolio";
            this.Text = "FrmPortafolio";
            this.Load += new System.EventHandler(this.FrmPortafolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.Label lblTituloImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}