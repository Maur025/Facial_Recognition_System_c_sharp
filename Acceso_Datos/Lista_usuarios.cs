using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Acceso_Datos
{
    public class Lista_usuarios:ConexionMySQL
    {        
        public DataTable mostrar() {
            using (var connection = GetConnection())
            {
                connection.Open();
                MySqlDataReader leer;
                DataTable tabla = new DataTable();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = "SELECT id_us AS Id,nombre_p AS Nombres,ap_pat AS Paterno,ap_mat AS Materno,nuci AS CI,nombre_us AS Usuario,pass AS Password,nivel as Privilegios,cargo AS Cargo FROM usuario";
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }

        public void Editar(string idusuario,string nombreu,string apepatu,string apematu,string username,string passu,int nivelu,string cargou,int cinum) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE usuario SET nombre_p=@nombreusu,ap_pat=@appatu,ap_mat=@apmatu,nuci=@numci,nombre_us=@usern,pass=@contra,nivel=@usnivel,cargo=@uscargo WHERE id_us=@idu";
                    command.Parameters.AddWithValue("@nombreusu",nombreu);
                    command.Parameters.AddWithValue("@appatu", apepatu);
                    command.Parameters.AddWithValue("@apmatu", apematu);
                    command.Parameters.AddWithValue("@usern", username);
                    command.Parameters.AddWithValue("@contra", passu);
                    command.Parameters.AddWithValue("@usnivel", nivelu);
                    command.Parameters.AddWithValue("@uscargo", cargou);
                    command.Parameters.AddWithValue("@idu", idusuario);
                    command.Parameters.AddWithValue("@numci",cinum);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void Eliminar(string idusuario) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM usuario WHERE id_us=@ide";
                    command.Parameters.AddWithValue("@ide",idusuario);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
