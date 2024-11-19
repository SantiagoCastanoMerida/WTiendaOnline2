namespace WTiendaOnline.UI
{
    partial class RecuadroProducto
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
            this.lblNombres = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrecios = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnInformacion = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.panProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panProducto
            // 
            this.panProducto.BorderColor = System.Drawing.Color.Silver;
            this.panProducto.BorderThickness = 2;
            this.panProducto.Controls.Add(this.imgProducto);
            this.panProducto.Controls.Add(this.lblNombres);
            this.panProducto.Controls.Add(this.lblNombre);
            this.panProducto.Controls.Add(this.lblPrecios);
            this.panProducto.Controls.Add(this.btnInformacion);
            this.panProducto.Controls.Add(this.lblPrecio);
            this.panProducto.Location = new System.Drawing.Point(0, 0);
            this.panProducto.MaximumSize = new System.Drawing.Size(166, 136);
            this.panProducto.MinimumSize = new System.Drawing.Size(166, 136);
            this.panProducto.Name = "panProducto";
            this.panProducto.Size = new System.Drawing.Size(166, 136);
            this.panProducto.TabIndex = 2;
            // 
            // lblNombres
            // 
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(60, 86);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(10, 17);
            this.lblNombres.TabIndex = 39;
            this.lblNombres.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 17);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecios
            // 
            this.lblPrecios.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecios.Location = new System.Drawing.Point(60, 109);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(10, 17);
            this.lblPrecios.TabIndex = 37;
            this.lblPrecios.Text = "0";
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.BorderColor = System.Drawing.Color.Transparent;
            this.btnInformacion.BorderRadius = 15;
            this.btnInformacion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInformacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInformacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInformacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInformacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInformacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInformacion.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnInformacion.ForeColor = System.Drawing.Color.White;
            this.btnInformacion.Location = new System.Drawing.Point(129, 103);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(34, 30);
            this.btnInformacion.TabIndex = 36;
            this.btnInformacion.Text = "+";
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(3, 109);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(41, 17);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // imgProducto
            // 
            this.imgProducto.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba;
            this.imgProducto.Location = new System.Drawing.Point(2, 2);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(161, 65);
            this.imgProducto.TabIndex = 0;
            this.imgProducto.TabStop = false;
            // 
            // RecuadroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panProducto);
            this.MaximumSize = new System.Drawing.Size(166, 136);
            this.MinimumSize = new System.Drawing.Size(166, 136);
            this.Name = "RecuadroProducto";
            this.Size = new System.Drawing.Size(166, 136);
            this.panProducto.ResumeLayout(false);
            this.panProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private System.Windows.Forms.PictureBox imgProducto;
        private Guna.UI2.WinForms.Guna2Button btnInformacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecios;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombres;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
    }
}
