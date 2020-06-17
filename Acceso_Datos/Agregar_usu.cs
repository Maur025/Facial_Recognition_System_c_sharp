using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Acceso_Datos
{
    public class Agregar_usu:ConexionMySQL
    {
        public void guardarUsu(string id,string nombre,string apat,string amat,int ci,string usuario,string contr,int priv,string carg)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new MySqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "INSERT INTO usuario(id_us,nombre_p,ap_pat,ap_mat,nuci,nombre_us,pass,nivel,cargo) VALUES(@uid,@unombre,@uapat,@uamat,@uci,@uusu,@upass,@univel,@ucargo)";
                    comand.Parameters.AddWithValue("@uid",id);
                    comand.Parameters.AddWithValue("@unombre",nombre);
                    comand.Parameters.AddWithValue("@uapat",apat);
                    comand.Parameters.AddWithValue("@uamat", amat);
                    comand.Parameters.AddWithValue("@uci", ci);
                    comand.Parameters.AddWithValue("@uusu", usuario);
                    comand.Parameters.AddWithValue("@upass", contr);
                    comand.Parameters.AddWithValue("@univel",priv);
                    comand.Parameters.AddWithValue("@ucargo", carg);
                    comand.ExecuteNonQuery();
                }
            }
        }

    }
}
