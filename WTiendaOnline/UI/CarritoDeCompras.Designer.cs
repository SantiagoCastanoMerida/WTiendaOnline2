namespace WTiendaOnline.UI
{
    partial class CarritoDeCompras
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
            this.lblProductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnHacerPago = new Guna.UI2.WinForms.Guna2Button();
            this.panLinea = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPreciTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResumen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.productoEnCarrito1 = new WTiendaOnline.UI.ProductoEnCarrito();
            this.panCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(77, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carrito";
            // 
            // lblProductos
            // 
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblProductos.Location = new System.Drawing.Point(22, 73);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(121, 26);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Tus Productos";
            // 
            // panCompra
            // 
            this.panCompra.BorderColor = System.Drawing.Color.Silver;
            this.panCompra.BorderRadius = 20;
            this.panCompra.BorderThickness = 2;
            this.panCompra.Controls.Add(this.guna2HtmlLabel1);
            this.panCompra.Controls.Add(this.btnHacerPago);
            this.panCompra.Controls.Add(this.panLinea);
            this.panCompra.Controls.Add(this.lblPreciTotal);
            this.panCompra.Controls.Add(this.lblResumen);
            this.panCompra.Location = new System.Drawing.Point(611, 32);
            this.panCompra.Name = "panCompra";
            this.panCompra.Size = new System.Drawing.Size(275, 428);
            this.panCompra.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 15F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 227);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(150, 26);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Metodos de pago";
            // 
            // btnHacerPago
            // 
            this.btnHacerPago.BorderRadius = 20;
            this.btnHacerPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHacerPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHacerPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHacerPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHacerPago.FillColor = System.Drawing.Color.Orange;
            this.btnHacerPago.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPago.ForeColor = System.Drawing.Color.White;
            this.btnHacerPago.Location = new System.Drawing.Point(31, 156);
            this.btnHacerPago.Name = "btnHacerPago";
            this.btnHacerPago.Size = new System.Drawing.Size(222, 45);
            this.btnHacerPago.TabIndex = 8;
            this.btnHacerPago.Text = "Hacer pago del pedido";
            // 
            // panLinea
            // 
            this.panLinea.BorderColor = System.Drawing.Color.Silver;
            this.panLinea.BorderThickness = 3;
            this.panLinea.Location = new System.Drawing.Point(6, 129);
            this.panLinea.Name = "panLinea";
            this.panLinea.Size = new System.Drawing.Size(268, 5);
            this.panLinea.TabIndex = 7;
            // 
            // lblPreciTotal
            // 
            this.lblPreciTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPreciTotal.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblPreciTotal.Location = new System.Drawing.Point(3, 80);
            this.lblPreciTotal.Name = "lblPreciTotal";
            this.lblPreciTotal.Size = new System.Drawing.Size(102, 26);
            this.lblPreciTotal.TabIndex = 6;
            this.lblPreciTotal.Text = "Precio Total";
            // 
            // lblResumen
            // 
            this.lblResumen.BackColor = System.Drawing.Color.Transparent;
            this.lblResumen.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(48, 14);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(186, 35);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Resumen Pedido";
            // 
            // productoEnCarrito1
            // 
            this.productoEnCarrito1.BackColor = System.Drawing.Color.Transparent;
            this.productoEnCarrito1.Location = new System.Drawing.Point(22, 123);
            this.productoEnCarrito1.MinimumSize = new System.Drawing.Size(583, 85);
            this.productoEnCarrito1.Name = "productoEnCarrito1";
            this.productoEnCarrito1.Size = new System.Drawing.Size(583, 85);
            this.productoEnCarrito1.TabIndex = 5;
            // 
            // CarritoDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productoEnCarrito1);
            this.Controls.Add(this.panCompra);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(0, 70);
            this.Name = "CarritoDeCompras";
            this.Size = new System.Drawing.Size(900, 480);
            this.panCompra.ResumeLayout(false);
            this.panCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductos;
        private Guna.UI2.WinForms.Guna2Panel panCompra;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPreciTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResumen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnHacerPago;
        private Guna.UI2.WinForms.Guna2Panel panLinea;
        private ProductoEnCarrito productoEnCarrito1;
    }
}
