namespace WTiendaOnline.UI
{
    partial class ProductoSelecionado
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
            this.panProducto = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnComprar = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreProducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panProducto
            // 
            this.panProducto.BorderColor = System.Drawing.Color.Black;
            this.panProducto.BorderThickness = 3;
            this.panProducto.Controls.Add(this.btnSalir);
            this.panProducto.Controls.Add(this.pictureBox1);
            this.panProducto.Controls.Add(this.guna2NumericUpDown1);
            this.panProducto.Controls.Add(this.btnComprar);
            this.panProducto.Controls.Add(this.lblPrecio);
            this.panProducto.Controls.Add(this.lblDescripcion);
            this.panProducto.Controls.Add(this.lblNombreProducto);
            this.panProducto.Location = new System.Drawing.Point(0, 0);
            this.panProducto.Name = "panProducto";
            this.panProducto.Size = new System.Drawing.Size(501, 318);
            this.panProducto.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BorderRadius = 30;
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 55);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "X";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba_2;
            this.pictureBox1.Location = new System.Drawing.Point(28, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderThickness = 0;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Calibri", 12F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(304, 165);
            this.guna2NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(60, 17);
            this.guna2NumericUpDown1.TabIndex = 5;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Orange;
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnComprar
            // 
            this.btnComprar.BorderRadius = 20;
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.FillColor = System.Drawing.Color.Orange;
            this.btnComprar.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(284, 206);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(205, 41);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Agregar al carrito";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(395, 165);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 19);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "1000000";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = false;
            this.lblDescripcion.AutoSizeHeightOnly = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(284, 93);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(197, 58);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Fina olla De materiales desechales para que se dañe rapido";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProducto.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.Location = new System.Drawing.Point(293, 59);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(84, 23);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Olla Presón";
            // 
            // ProductoSelecionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panProducto);
            this.Location = new System.Drawing.Point(200, 120);
            this.Name = "ProductoSelecionado";
            this.Size = new System.Drawing.Size(501, 318);
            this.panProducto.ResumeLayout(false);
            this.panProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panProducto;
        private Guna.UI2.WinForms.Guna2Button btnComprar;
        private System.Windows.Forms.Label lblPrecio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
    }
}
