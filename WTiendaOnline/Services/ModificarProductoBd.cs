using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class ModificarProductoBd
    {
        ConexionBd conexion = new ConexionBd();
        public bool ModificarProducto(int id, string nombre, string descripcion, decimal precio, int cantidad)
        {
            string query = "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, CantidadInventario=@Cantidad" +
                " WHERE ProductoID= @Id";

            try
            {
                var conectar = conexion.Conexion;
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);
                    comando.Parameters.AddWithValue("@Id", id);
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
