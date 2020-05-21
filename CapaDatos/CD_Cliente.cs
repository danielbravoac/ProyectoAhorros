using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cliente
    {
        private clsCadenaConexion Conexion = new clsCadenaConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarCliente(string numDocumento, int tipoDocumento)
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AhoBusCliente_sp";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cNumDocumento", numDocumento);
            Comando.Parameters.AddWithValue("@nTipoDocumento", tipoDocumento);
            Comando.ExecuteNonQuery();            
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
            return Tabla;
        }
    }
}
