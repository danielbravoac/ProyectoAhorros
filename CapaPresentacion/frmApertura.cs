using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmApertura : Form
    {
        CN_TipoCuenta CNTipoCuenta = new CN_TipoCuenta();
        CN_Moneda CNMoneda = new CN_Moneda();
        CN_Cuenta CNCuenta = new CN_Cuenta();
        private void ListarTipoCuenta()
        {
            cmbTipoCuenta.DataSource = CNTipoCuenta.MostrarTipoDocumento();
            cmbTipoCuenta.DisplayMember = "cNombreCuenta";
            cmbTipoCuenta.ValueMember = "nCodigoCuenta";
        }
        private void ListarMoneda()
        {
            cmbMoneda.DataSource = CNMoneda.MostrarMoneda();
            cmbMoneda.DisplayMember = "cNombreMoneda";
            cmbMoneda.ValueMember = "nCodMoneda";
        }
        public frmApertura()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmClientes Clientes = new frmClientes();
            AddOwnedForm(Clientes);
            Clientes.ShowDialog();
        }

        private void frmApertura_Load(object sender, EventArgs e)
        {
            ListarTipoCuenta();
            ListarMoneda();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
                if (Convert.ToDecimal(nudMontoApertura.Value) < 20)
                {
                    MessageBox.Show("El monto de apertura debe ser mayor o igual a 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txtDocumento.Text == "")
                {
                    MessageBox.Show("No se ha elegido un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RegistrarCuenta();
                    Limpiar(this,grpDatosCliente);
                Limpiar(this, grpDatosCuenta);
                frmAperturaCuenta Apertura = new frmAperturaCuenta();
                    Apertura.ShowDialog();
            }            
        }
        private void RegistrarCuenta()
        {
            //Procedimiento de Guardado
            try
            {
                string codCliente = varSuperGlobal.Cliente;
                int codTipoCuenta = Convert.ToInt16(cmbTipoCuenta.SelectedValue);
                int codMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
                DateTime dFechaApertura = Convert.ToDateTime(dtpFechaApertura.Value).Date;
                int codTipoMoneda = Convert.ToInt16(cmbMoneda.SelectedValue);
                double montoDispo = Convert.ToDouble(nudMontoApertura.Value);
                double montoCont = Convert.ToDouble(nudMontoApertura.Value);
                int codEstado = 1;
                string codUsuario = varSuperGlobal.Usuario;
                string codUsuModifica = varSuperGlobal.Usuario;
                CNCuenta.InsertarCuenta(codCliente, codTipoCuenta, codMoneda, dFechaApertura,
        codTipoMoneda, montoDispo, montoCont, codEstado, codUsuario,
        codUsuModifica);
                MessageBox.Show("Cuenta Creada Correctamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar datos: " + ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Limpiar(Control control,GroupBox gb)
        {
            foreach(var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if(txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
                else if(txt is NumericUpDown)
                {
                    ((NumericUpDown)txt).Value = 0;
                }
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = 0;
                }
                else if (combo is NumericUpDown)
                {
                    ((NumericUpDown)combo).Value = 0;
                }
            }
        }
    }
}
