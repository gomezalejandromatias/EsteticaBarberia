namespace SisteaEsteticaBarberia
{
    partial class FrmProductosServicios
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
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lblPrecioServicio = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(430, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agrege Productos/Servicios";
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(421, 203);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioServicio.TabIndex = 1;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(421, 149);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreServicio.TabIndex = 2;
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Location = new System.Drawing.Point(238, 152);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(102, 13);
            this.lblNombreServicio.TabIndex = 3;
            this.lblNombreServicio.Text = "Nombre del Servicio";
            // 
            // lblPrecioServicio
            // 
            this.lblPrecioServicio.AutoSize = true;
            this.lblPrecioServicio.Location = new System.Drawing.Point(238, 203);
            this.lblPrecioServicio.Name = "lblPrecioServicio";
            this.lblPrecioServicio.Size = new System.Drawing.Size(95, 13);
            this.lblPrecioServicio.TabIndex = 4;
            this.lblPrecioServicio.Text = "Precio Del Servico";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(681, 203);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarServicio.TabIndex = 5;
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Location = new System.Drawing.Point(241, 278);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.Size = new System.Drawing.Size(329, 150);
            this.dgvTipoServicio.TabIndex = 6;
            // 
            // FrmProductosServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.lblPrecioServicio);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmProductosServicios";
            this.Text = "FrmProductosServicios";
            this.Load += new System.EventHandler(this.FrmProductosServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Label lblPrecioServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
    }
}