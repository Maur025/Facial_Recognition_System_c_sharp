using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Acceso_Datos
{
    public class Lista_registros:ConexionMySQL
    {
        public DataTable mostrar2()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlDataReader leer;
                DataTable tabla = new DataTable();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = "SELECT cib as CI,nombreb as Nombre,ubicacionimage as Ubicacion,apepatb as Paterno,apematb as Materno,edadb as Edad,generob as Genero,id_us as Registrado,buscado as Buscado FROM buscar";
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }
        public void EliminarReg(int idreg)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM buscar WHERE cib=@ide";
                    command.Parameters.AddWithValue("@ide", idreg);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
