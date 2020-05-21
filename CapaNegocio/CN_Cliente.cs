using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente Cliente = new CapaDatos.CD_Cliente();
        public DataTable MostrarCliente(string numeroDocumento, int tipoDocumento)
        {
            DataTable Tabla = new DataTable();
            Tabla = Cliente.ListarCliente(numeroDocumento,tipoDocumento);
            return Tabla;
        }
    }
}
