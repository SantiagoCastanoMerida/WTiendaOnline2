namespace WTiendaOnline.UI
{
    partial class HeaderTienda
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
            this.panTienda = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnContacto = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panTienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panTienda
            // 
            this.panTienda.BackColor = System.Drawing.Color.White;
            this.panTienda.BorderColor = System.Drawing.Color.Silver;
            this.panTienda.BorderThickness = 2;
            this.panTienda.Controls.Add(this.txtBusqueda);
            this.panTienda.Controls.Add(this.btnPerfil);
            this.panTienda.Controls.Add(this.btnCompras);
            this.panTienda.Controls.Add(this.btnContacto);
            this.panTienda.Controls.Add(this.btnHome);
            this.panTienda.Controls.Add(this.imgLogo);
            this.panTienda.CustomBorderColor = System.Drawing.Color.Silver;
            this.panTienda.FillColor = System.Drawing.Color.Orange;
            this.panTienda.FillColor2 = System.Drawing.Color.Orange;
            this.panTienda.FillColor3 = System.Drawing.Color.Orange;
            this.panTienda.FillColor4 = System.Drawing.Color.Orange;
            this.panTienda.ForeColor = System.Drawing.Color.Orange;
            this.panTienda.Location = new System.Drawing.Point(0, 0);
            this.panTienda.Name = "panTienda";
            this.panTienda.Size = new System.Drawing.Size(900, 72);
            this.panTienda.TabIndex = 0;
            // 
            // btnContacto
            // 
            this.btnContacto.BackColor = System.Drawing.Color.Transparent;
            this.btnContacto.BorderColor = System.Drawing.Color.Transparent;
            this.btnContacto.BorderThickness = 1;
            this.btnContacto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContacto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContacto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContacto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContacto.FillColor = System.Drawing.Color.Transparent;
            this.btnContacto.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnContacto.ForeColor = System.Drawing.Color.Black;
            this.btnContacto.Location = new System.Drawing.Point(172, 15);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(107, 45);
            this.btnContacto.TabIndex = 10;
            this.btnContacto.Text = "Contacto";
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(88, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(78, 45);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtBusqueda.BorderColor = System.Drawing.Color.Black;
            this.txtBusqueda.BorderRadius = 20;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.IconRight = global::WTiendaOnline.Properties.Resources.Search;
            this.txtBusqueda.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtBusqueda.Location = new System.Drawing.Point(319, 15);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(295, 45);
            this.txtBusqueda.TabIndex = 13;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BorderColor = System.Drawing.Color.Transparent;
            this.btnPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPerfil.FillColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPerfil.ForeColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Image = global::WTiendaOnline.Properties.Resources.User;
            this.btnPerfil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPerfil.Location = new System.Drawing.Point(776, 15);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(52, 45);
            this.btnPerfil.TabIndex = 12;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BorderColor = System.Drawing.Color.Transparent;
            this.btnCompras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompras.FillColor = System.Drawing.Color.Transparent;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompras.ForeColor = System.Drawing.Color.Transparent;
            this.btnCompras.Image = global::WTiendaOnline.Properties.Resources.ShopCar;
            this.btnCompras.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCompras.Location = new System.Drawing.Point(834, 15);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(52, 45);
            this.btnCompras.TabIndex = 11;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::WTiendaOnline.Properties.Resources.Logo_Clic_Shop_Black;
            this.imgLogo.ImageLocation = "";
            this.imgLogo.Location = new System.Drawing.Point(13, 8);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(68, 61);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 6;
            this.imgLogo.TabStop = false;
            // 
            // HeaderTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panTienda);
            this.Name = "HeaderTienda";
            this.Size = new System.Drawing.Size(900, 72);
            this.panTienda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panTienda;
        private System.Windows.Forms.PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnContacto;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2Button btnPerfil;
        private Guna.UI2.WinForms.Guna2Button btnCompras;
    }
}
