using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class ModificarUsuarioBd
    {
        ConexionBd conexion = new ConexionBd();
        public bool ModificarUsuario(string nombre, string email, string direccion, string telefono, string emailActual)
        {
            string query = @"UPDATE Clientes SET Nombre=@Nombre, Direccion=@Direccion, Telefono=@Telefono, Email=@Email WHERE Email = @EmailActual";

            try
            {
                var conectar = conexion.Conexion;
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Direccion", direccion);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@EmailActual", emailActual);
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
