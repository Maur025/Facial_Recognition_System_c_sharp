using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Acceso_Datos
{
    public class datos_buscar:ConexionMySQL
    {
        public void guardarbusq(int ci, string nombreb, string apatb, string amatb, int edadb, string genero, string imagen,string idusu)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO buscar(cib,nombreb,ubicacionimage,apepatb,apematb,edadb,generob,id_us) VALUES (@ci,@nombre,@direccioni,@apellido1,@apellido2,@ed,@sexo,@idusuario)";
                    command.Parameters.AddWithValue("@ci", ci);
                    command.Parameters.AddWithValue("@nombre", nombreb);
                    command.Parameters.AddWithValue("@direccioni", imagen);
                    command.Parameters.AddWithValue("@apellido1", apatb);
                    command.Parameters.AddWithValue("@apellido2", amatb);
                    command.Parameters.AddWithValue("@ed", edadb);
                    command.Parameters.AddWithValue("@sexo", genero);
                    command.Parameters.AddWithValue("@idusuario", idusu);
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
