using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Acceso_Datos
{
    public abstract class ConexionMySQL
    {
        private readonly string connectionString;
        public ConexionMySQL() {
            connectionString = "SERVER=127.0.0.1;PORT=3306;DATABASE=db_reconocimiento;UID=root;PASSWORD=;";
        }
        protected MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }
    }
}
