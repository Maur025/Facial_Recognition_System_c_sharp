using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;

namespace Dominio
{
    public class Modelo_agregar_usu
    {
        private Agregar_usu newuser = new Agregar_usu();
        public void insertarUsuario(string id1, string nombre1, string apat1, string amat1, string ci1, string usuario1, string contr1, string priv1, string carg1) {
            int nivelpriv = 0;
            if (priv1 == "ADMINISTRADOR")
            {
                nivelpriv = 0;
            }
            else if (priv1 == "EMPLEADO")
            {
                nivelpriv = 1;
            }
            else
            {
                nivelpriv = 2;
            }
            newuser.guardarUsu(id1,nombre1,apat1,amat1,int.Parse(ci1),usuario1,contr1,nivelpriv,carg1);
        }
    }
}
