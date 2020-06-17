using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Soporte.Cache;

namespace Acceso_Datos
{
    public class Datos_Usuario:ConexionMySQL
    {
        public bool Login(string user, string pass) {
            using (var connection = GetConnection()) {
                try
                {
                    connection.Open();
                }
                catch
                {
                    return false;
                }                
                using (var comand = new MySqlCommand()) {
                    comand.Connection = connection;
                    comand.CommandText = "SELECT * FROM usuario WHERE nombre_us=@user AND pass=@pass";
                    comand.Parameters.AddWithValue("@user", user);
                    comand.Parameters.AddWithValue("@pass", pass);
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            CacheLoginUser.iduser = reader.GetString(0);                            
                            CacheLoginUser.nombre = reader.GetString(1);
                            CacheLoginUser.apellidopat = reader.GetString(2);
                            CacheLoginUser.apellidomat = reader.GetString(3);
                            CacheLoginUser.numci = reader.GetInt32(4);
                            CacheLoginUser.nomuser = reader.GetString(5);                            
                            CacheLoginUser.privilegios = reader.GetInt32(7);
                            CacheLoginUser.cargo = reader.GetString(8);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
