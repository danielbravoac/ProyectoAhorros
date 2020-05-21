using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_TipoDocumento
    {
        private CD_TipoDocumento TipoDoc = new CapaDatos.CD_TipoDocumento();
        public DataTable MostrarTipoDocumento()
        {
            DataTable Tabla = new DataTable();
            Tabla = TipoDoc.ListarTipoDocumento();
            return Tabla;
        }
    }
}
