using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cuenta
    {
        private clsCadenaConexion Conexion = new clsCadenaConexion();
        private SqlCommand Comando = new SqlCommand();
        public void InsertarCuenta(string codCliente, int codTipoCuenta, int codMoneda, DateTime dFechaApertura,
            int codTipoMoneda, double montoDispo, double montoCont, int codEstado,string codUsuario,
            string codUsuModifica)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AhoInsCuenta_sp";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cCodCliente", codCliente);
            Comando.Parameters.AddWithValue("@nCodTipCuenta", codTipoCuenta);
            Comando.Parameters.AddWithValue("@nCodMoneda", codMoneda);
            Comando.Parameters.AddWithValue("@dFechaApertura", dFechaApertura);
            Comando.Parameters.AddWithValue("@nCodTipMoneda", codTipoMoneda);
            Comando.Parameters.AddWithValue("@nMontoDisponible", montoDispo);
            Comando.Parameters.AddWithValue("@nMontoContable", montoCont);
            Comando.Parameters.AddWithValue("@nCodEstadoCta", codEstado);
            Comando.Parameters.AddWithValue("@cCodUsuario", codUsuario);
            Comando.Parameters.AddWithValue("@cCodUsuModifica", codUsuModifica);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }

    }
}
