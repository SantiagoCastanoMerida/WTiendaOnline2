using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WTiendaOnline.Services
{
    public class ConexionBd
    {
        private static string Usuario = "DESKTOP-6O8555G";
        private static string Server = "localhost";
        private static string Password = "";
        private static string Bd = "SimuladorTiendaOnline";

        //conexion con autenticaciond de windows
        private static string ConexionString = $"Server={Server};Database={Bd};Integrated Security=True;";
        private SqlConnection ConexionSql;

        public SqlConnection Conexion
        {
            get
            {
                if (ConexionSql == null)
                {
                    CrearConexion();
                }
                return ConexionSql;
            }
        }
        public void CrearConexion()
        {
            
            try
            {
                ConexionSql = new SqlConnection(ConexionString);
                ConexionSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                throw;
            }
        }
        public void CerrarConexion()
        {
            if (ConexionSql != null && ConexionSql.State == System.Data.ConnectionState.Open)
            {
                ConexionSql.Close();
                MessageBox.Show("Conexión Cerrada");
            }
        }
    }

}
