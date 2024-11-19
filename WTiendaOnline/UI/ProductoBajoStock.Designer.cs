namespace WTiendaOnline.UI
{
    partial class ProductoBajoStock
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
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSinProductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Producto en bajo Stock";
            // 
            // lblSinProductos
            // 
            this.lblSinProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblSinProductos.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinProductos.Location = new System.Drawing.Point(166, 194);
            this.lblSinProductos.Name = "lblSinProductos";
            this.lblSinProductos.Size = new System.Drawing.Size(526, 51);
            this.lblSinProductos.TabIndex = 2;
            this.lblSinProductos.Text = "No hay productos en bajo stock";
            this.lblSinProductos.Visible = false;
            // 
            // ProductoBajoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSinProductos);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(0, 70);
            this.MaximumSize = new System.Drawing.Size(900, 480);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "ProductoBajoStock";
            this.Size = new System.Drawing.Size(900, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSinProductos;
    }
}
