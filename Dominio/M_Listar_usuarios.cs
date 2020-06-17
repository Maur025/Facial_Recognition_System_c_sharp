using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;
using System.Data;

namespace Dominio
{
    public class M_Listar_usuarios
    {
        private Lista_usuarios usuobjeto = new Lista_usuarios();

        public DataTable Mostrarusu() {
            DataTable tabla = new DataTable();
            tabla = usuobjeto.mostrar();
            return tabla;
        }
        public void EditarUsu(string idusuario1, string nombreu1, string apepatu1, string apematu1, string username1, string passu1, int nivelu1, string cargou1,string cinum1)
        {
            usuobjeto.Editar(idusuario1,nombreu1,apepatu1,apematu1,username1,passu1,nivelu1,cargou1,int.Parse(cinum1));
        }
        public void EliminarUsu(string idusuario1) {
            usuobjeto.Eliminar(idusuario1);
        }
    }
    
}
