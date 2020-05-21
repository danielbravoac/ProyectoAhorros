using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Moneda
    {
        private CD_Moneda Moneda = new CapaDatos.CD_Moneda();
        public DataTable MostrarMoneda()
        {
            DataTable Tabla = new DataTable();
            Tabla = Moneda.ListarMoneda();
            return Tabla;
        }
    }
}
