namespace WTiendaOnline.UI
{
    partial class ProductoEnCarrito
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanDetalles = new Guna.UI2.WinForms.Guna2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pckCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDescripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkProducto = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.PanDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanDetalles
            // 
            this.PanDetalles.BackColor = System.Drawing.Color.White;
            this.PanDetalles.BorderColor = System.Drawing.Color.Silver;
            this.PanDetalles.BorderRadius = 20;
            this.PanDetalles.BorderThickness = 2;
            this.PanDetalles.Controls.Add(this.chkProducto);
            this.PanDetalles.Controls.Add(this.pictureBox1);
            this.PanDetalles.Controls.Add(this.lblDescripcion);
            this.PanDetalles.Controls.Add(this.lblPrecio);
            this.PanDetalles.Controls.Add(this.pckCantidad);
            this.PanDetalles.Controls.Add(this.imgLogo);
            this.PanDetalles.Location = new System.Drawing.Point(0, 0);
            this.PanDetalles.MinimumSize = new System.Drawing.Size(583, 85);
            this.PanDetalles.Name = "PanDetalles";
            this.PanDetalles.Size = new System.Drawing.Size(583, 85);
            this.PanDetalles.TabIndex = 4;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba;
            this.imgLogo.Location = new System.Drawing.Point(48, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(68, 61);
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // pckCantidad
            // 
            this.pckCantidad.BackColor = System.Drawing.Color.Transparent;
            this.pckCantidad.BorderThickness = 0;
            this.pckCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pckCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pckCantidad.Location = new System.Drawing.Point(470, 51);
            this.pckCantidad.Name = "pckCantidad";
            this.pckCantidad.Size = new System.Drawing.Size(93, 31);
            this.pckCantidad.TabIndex = 8;
            this.pckCantidad.UpDownButtonFillColor = System.Drawing.Color.Orange;
            this.pckCantidad.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(135, 56);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 17);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = false;
            this.lblDescripcion.AutoSizeHeightOnly = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(135, 12);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(328, 35);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(322, 35);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Holas en venta para la compra y produccion de distintas cosas en la cocina, sirve" +
    "n tato para cocinar como para pegaraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba;
            this.pictureBox1.Location = new System.Drawing.Point(522, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // chkProducto
            // 
            this.chkProducto.BackColor = System.Drawing.Color.Transparent;
            this.chkProducto.Checked = true;
            this.chkProducto.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.chkProducto.CheckedState.BorderRadius = 20;
            this.chkProducto.CheckedState.BorderThickness = 2;
            this.chkProducto.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.chkProducto.Location = new System.Drawing.Point(7, 25);
            this.chkProducto.Name = "chkProducto";
            this.chkProducto.Size = new System.Drawing.Size(35, 35);
            this.chkProducto.TabIndex = 12;
            this.chkProducto.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.chkProducto.UncheckedState.BorderRadius = 20;
            this.chkProducto.UncheckedState.BorderThickness = 2;
            this.chkProducto.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.chkProducto.UseTransparentBackground = true;
            // 
            // ProductoEnCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanDetalles);
            this.MinimumSize = new System.Drawing.Size(583, 85);
            this.Name = "ProductoEnCarrito";
            this.Size = new System.Drawing.Size(583, 85);
            this.PanDetalles.ResumeLayout(false);
            this.PanDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanDetalles;
        private Guna.UI2.WinForms.Guna2NumericUpDown pckCantidad;
        private System.Windows.Forms.PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkProducto;
    }
}
