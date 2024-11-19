using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class CrearUsuariosBd
    {
        ConexionBd conexion = new ConexionBd();
        public bool CrearUsuario(string nombre, string email, string direccion, string telefono)
        {

            ObtenerUsuarioBd usuarios = new ObtenerUsuarioBd();
            if(usuarios.verificarPorCorreo(email))
            {
                MessageBox.Show("El correo ya esta en uso", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var conectar = conexion.Conexion;
                string query = "INSERT INTO Clientes (Nombre,Direccion,Telefono,Email) Values (@Nombre,@Direccion,@Telefono,@Email)";
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Direccion", direccion);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Email", email);
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
