using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_TipoCuenta
    {
        private CD_TipoCuenta TipoCuenta = new CapaDatos.CD_TipoCuenta();
        public DataTable MostrarTipoDocumento()
        {
            DataTable Tabla = new DataTable();
            Tabla = TipoCuenta.ListarTipoCuenta();
            return Tabla;
        }
    }
}
