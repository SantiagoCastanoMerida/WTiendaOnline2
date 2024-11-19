using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class CrearProductoBd
    {
        ConexionBd conexion = new ConexionBd();
        public bool CrearProducto(string nombre, string descripcion, decimal precio, int cantidad)
        {

            try
            {
                var conectar = conexion.Conexion;
                string query = "INSERT INTO Productos (Nombre,Descripcion,Precio,CantidadInventario) Values (@Nombre,@Descripcion,@Precio,@Cantidad)";
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }
        }
    }
}
