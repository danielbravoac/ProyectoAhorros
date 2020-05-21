using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class CN_Cuenta
    {
        private CD_Cuenta Cuenta = new CD_Cuenta();
        public void InsertarCuenta(string codCliente, int codTipoCuenta, int codMoneda, DateTime dFechaApertura,
            int codTipoMoneda, double montoDispo, double montoCont, int codEstado, string codUsuario,
            string codUsuModifica)
        {
            Cuenta.InsertarCuenta(codCliente, codTipoCuenta, codMoneda, dFechaApertura,
            codTipoMoneda, montoDispo, montoCont, codEstado, codUsuario,
            codUsuModifica);
        }
    }
}
