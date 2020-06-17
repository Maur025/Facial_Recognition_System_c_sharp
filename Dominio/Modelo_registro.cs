using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;

namespace Dominio
{
    public class Modelo_registro
    {
        private datos_buscar insertnewu = new datos_buscar();
        public void insertarusu(string ci1, string nombreb1, string apatb1, string amatb1, string edadb1, string genero1, string imagen1,string idusu1) {
            string congen = "";

            if (genero1 == "MASCULINO")
            {
                congen = "M";
            }
            else if (genero1 == "FEMENINO")
            {
                congen = "F";
            }
            else
            {
                congen = "";
            }

            if (edadb1 == "EDAD") {
                edadb1 = "0";
            }
            if (apatb1 == "APELLIDO PATERNO")
            {
                apatb1 = "";
            }
            if (amatb1 == "APELLIDO MATERNO")
            {
                amatb1 = "";
            }

            insertnewu.guardarbusq(int.Parse(ci1), nombreb1, apatb1, amatb1, int.Parse(edadb1),congen, imagen1,idusu1) ;
        }
    }
}
