using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTiendaOnline.Models;
using WTiendaOnline.Services;
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    public partial class ProductoBajoStock : UserControl
    {
        public readonly RecuadroProducto _producto;
        public List<Producto> productos = new List<Producto>();
        public ProductoBajoStock()
        {
            InitializeComponent();
        }

        public void LimpiarVista()
        {

            this.Controls.Clear();
        }
        //CArgar los productos
        public void CargarProductos()
        {
            //Crear LAbel
            Guna2HtmlLabel Titulo = new Guna2HtmlLabel
            {
                Name = "Titulo",
                Text = "Productos en bajo stock",
                Location = new Point(30, 10), // Posición en el formulario
                Size = new Size(261, 35), // Tamaño de la etiqueta
                Font = new Font("Calibri", 25, FontStyle.Bold), // Estilo de fuente
                ForeColor = Color.Black, // Color del texto
            };
            this.Controls.Add(Titulo);

            // Obtener los productos de la base de datos
            ObtenerProductosBd obtener = new ObtenerProductosBd();
            int stock = GlobalStock.MostrarStock();
            productos = obtener.productosEnBajoStock(stock);

            // Mostrar los productos en la interfaz de usuario
            int X = 40;
            int Y = 60;
            if (productos.Any())
            {
                lblSinProductos.Visible = false;
                foreach (var producto in productos)
                {
                    var recuadroProducto = new RecuadroProducto();
                    recuadroProducto.Precio = Convert.ToString(producto.precio);
                    recuadroProducto.Nombre = producto.name;
                    recuadroProducto.id = producto.id;


                    this.Controls.Add(recuadroProducto);
                    recuadroProducto.Location = new Point(X, Y);
                    X += 220;

                    if (X >= 780)
                    {
                        X = 40;
                        Y += 180;
                    }
                }
                return;
            }
            // Crear un labek en caso de que no se encuentre ningun producto
            Guna2HtmlLabel SinProductos = new Guna2HtmlLabel
            {
                Name = "Stock",
                Text = "No se encontraron productos en ese stock",
                Location = new Point(106, 194), // Posición en el formulario
                Size = new Size(526, 51), // Tamaño de la etiqueta
                Font = new Font("Calibri", 30, FontStyle.Bold), // Estilo de fuente
                ForeColor = Color.Black, // Color del texto
            };
            this.Controls.Add(SinProductos);
           
            return;
        }
    }
}
