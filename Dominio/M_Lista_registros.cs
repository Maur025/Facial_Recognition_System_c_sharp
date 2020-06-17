using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Acceso_Datos;

namespace Dominio
{
    public class M_Lista_registros
    {
        private Lista_registros regobjeto = new Lista_registros();

        public DataTable Mostrarreg()
        {
            DataTable tabla = new DataTable();
            tabla = regobjeto.mostrar2();
            return tabla;
        }
        public void EliminarRegis(string idreg1)
        {
            regobjeto.EliminarReg(int.Parse(idreg1));
        }
    }
}
