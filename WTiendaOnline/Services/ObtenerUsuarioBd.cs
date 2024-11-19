using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTiendaOnline.Models;

namespace WTiendaOnline.Services
{
    public class ObtenerUsuarioBd
    {
        ConexionBd conexion = new ConexionBd();

        
        public bool conseguirUsuarioLogin(string correo, string telefono) 
        {
            var conectar = conexion.Conexion;
            string query = "SELECT COUNT(1) FROM Clientes WHERE Email = @Email AND Telefono = @Telefono";
            using (SqlCommand comando = new SqlCommand(query, conectar))
            {
                comando.Parameters.AddWithValue("@Email", correo);
                comando.Parameters.AddWithValue("@Telefono", telefono);

                int count = (int)comando.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarPorCorreo(string correo)
        {
            var conectar = conexion.Conexion;
            string query = "SELECT COUNT(1) FROM Clientes WHERE Email = @Email";
            using (SqlCommand comando = new SqlCommand(query, conectar))
            {
                comando.Parameters.AddWithValue("@Email", correo);

                int count = (int)comando.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public Cliente ObtenerDatos(string email)
        {
            var conectar = conexion.Conexion;
            string query = "SELECT * FROM Clientes WHERE Email = @Email";

            try
            {
                using (SqlCommand comando = new SqlCommand(query, conectar))
                {
                    comando.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            return new Cliente
                            {
                                id = Reader.GetInt32(0),
                                name = Reader.GetString(1),
                                direccion = Reader.GetString(2),
                                telefono = Reader.GetString(3),
                                email = Reader.GetString(4)
                            };
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar usuario", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;

        }
    }
    
}
