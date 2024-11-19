using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WTiendaOnline.Models;

using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class ObtenerProductosBd
    {
        ConexionBd conexion = new ConexionBd();
        public List<Producto> Productos()
        {
            List<Producto> productos = new List<Producto>();

            string query = "Select * from Productos";
            try
            {
                var conectar = conexion.Conexion;
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                id = Reader.GetInt32(0),
                                name = Reader.GetString(1),
                                descripcion = Reader.GetString(2),
                                precio = Reader.GetDecimal(3),
                                cantidad = Reader.GetInt32(4)
                            };
                            productos.Add(producto);
                        }
                    } 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                throw;
            }
            return productos;

        }
        public Producto obtenerPorId(int id)
        {
            

            string query = "Select * from Productos WHERE ProductoID = @Id";
            try
            {
                var conectar = conexion.Conexion;
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                id = Reader.GetInt32(0),
                                name = Reader.GetString(1),
                                descripcion = Reader.GetString(2),
                                precio = Reader.GetDecimal(3),
                                cantidad = Reader.GetInt32(4)
                            };
                            return producto;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                throw;
            }
            MessageBox.Show("Producto No encontrado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;

        }
        public List<Producto> productosEnBajoStock(int stock)
        {
            List<Producto> productos = new List<Producto>();

            string query = "Select * from Productos WHERE CantidadInventario <= @Stock";
            try
            {
                var conectar = conexion.Conexion;
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Stock", stock);
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        
                        while (Reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                id = Reader.GetInt32(0),
                                name = Reader.GetString(1),
                                descripcion = Reader.GetString(2),
                                precio = Reader.GetDecimal(3),
                                cantidad = Reader.GetInt32(4)
                            };
                            productos.Add(producto);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                throw;
            }
            return productos;

        }
    }
}
