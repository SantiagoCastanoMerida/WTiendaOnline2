namespace WTiendaOnline.UI
{
    partial class HeaderLogin
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
            this.lblEslogan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEslogan
            // 
            this.lblEslogan.BackColor = System.Drawing.Color.Transparent;
            this.lblEslogan.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblEslogan.Location = new System.Drawing.Point(87, 29);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(379, 15);
            this.lblEslogan.TabIndex = 6;
            this.lblEslogan.Text = "¡Descubre lo que deseas a un clic de distancia!";
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::WTiendaOnline.Properties.Resources.Logo_Clic_Shop_Black;
            this.imgLogo.Location = new System.Drawing.Point(13, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(68, 61);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // HeaderLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.lblEslogan);
            this.Controls.Add(this.imgLogo);
            this.Name = "HeaderLogin";
            this.Size = new System.Drawing.Size(900, 72);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblEslogan;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}
