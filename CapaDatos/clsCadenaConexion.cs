using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class clsCadenaConexion
    {
        static private string CadenaConexion = "Server=DESKTOP-MOD3SHO;Database=Ahorros;Trusted_Connection=True;";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion() {
            if (Conexion.State == ConnectionState.Closed)            
                Conexion.Open();
            return Conexion;
            
        }
        public SqlConnection CerrarConexion() {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;            
        }
         
    }
}
