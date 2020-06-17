using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;


namespace Dominio
{
    public class Modelo_usuario
    {
        Datos_Usuario datos_us = new Datos_Usuario();
        public bool LoginUser(string user, string pass) {
            return datos_us.Login(user, pass);
        }
    }
}
