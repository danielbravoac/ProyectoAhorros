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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        CN_TipoDocumento CNTipoDoc = new CN_TipoDocumento();
        CN_Cliente CNCliente = new CN_Cliente();
        public frmClientes()
        {
            InitializeComponent();
            
        }
        private void ListarTipoDocumento()
        {
            cmbTipoDocumento.DataSource = CNTipoDoc.MostrarTipoDocumento();
            cmbTipoDocumento.DisplayMember = "cDesCorta";
            cmbTipoDocumento.ValueMember = "nCodTipDocumento";
        }

        private void ListarCliente()
        {
            string numeroDocumento = txtNumeroDocumento.Text;
            int tipoDocumento = Convert.ToInt16(cmbTipoDocumento.SelectedValue);
            try
            {
                dgvClientes.DataSource = CNCliente.MostrarCliente(numeroDocumento, tipoDocumento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Inexistentes" + ex);
            }
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarTipoDocumento();
            txtNumeroDocumento.Select();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento.Clear();
            txtNumeroDocumento.Select();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            varSuperGlobal.Cliente= dgvClientes.CurrentRow.Cells[0].Value.ToString();
            frmApertura Apertura = Owner as frmApertura;
            Apertura.txtDocumento.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            Apertura.txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apertura.txtApellidoPat.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            Apertura.txtApellidoMat.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
