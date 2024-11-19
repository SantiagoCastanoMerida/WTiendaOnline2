using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WTiendaOnline.Utils;
using WTiendaOnline.Models;
using WTiendaOnline.Services;
using Guna.UI2.WinForms;

namespace WTiendaOnline.UI
{
    public partial class Productos : UserControl
    {
        public event Action<string> OnNavigate;
        public readonly RecuadroProducto _producto;
        public List<Producto> productos = new List<Producto>();
        public Productos()
        {
            InitializeComponent();

        }
        //Limpiar todos los productos en la vista
        public void LimpiarVista()
        {

            this.Controls.Clear();
        }
        //CArgar los productos
        public void CargarProductos()
        {
            //Crear label
            Guna2HtmlLabel Titulo = new Guna2HtmlLabel
            {
                Name = "Titulo",
                Text = "Productos",
                Location = new Point(30, 10),
                Size = new Size(261, 35),
                Font = new Font("Calibri", 25, FontStyle.Bold),
                ForeColor = Color.Black,
            };
            this.Controls.Add(Titulo);

            // Obtener los productos de la base de datos
            ObtenerProductosBd obtener = new ObtenerProductosBd();
            productos = obtener.Productos();

            // Mostrar los productos en la interfaz de usuario
            int X = 40;
            int Y = 60;
            foreach (var producto in productos)
            {
                var recuadroProducto = new RecuadroProducto();
                recuadroProducto.Precio = Convert.ToString(producto.precio);
                recuadroProducto.Nombre = producto.name;
                recuadroProducto.id = producto.id;

                recuadroProducto.Click += (sender, e) => OnRecuadroClick(recuadroProducto);


                this.Controls.Add(recuadroProducto);
                recuadroProducto.Location = new Point(X, Y);
                X += 220;

                if (X >= 780)
                {
                    X = 40;
                    Y += 180;
                }
            }
        }
        private void OnRecuadroClick(RecuadroProducto recuadro)
        {
            
            OnNavigate?.Invoke("ProductoSelecioando");
        }
    }
}
