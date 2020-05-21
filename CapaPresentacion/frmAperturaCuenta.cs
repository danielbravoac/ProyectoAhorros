using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAperturaCuenta : Form
    {
        public frmAperturaCuenta()
        {
            InitializeComponent();
        }

        private void frmAperturaCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AhorrosDataSet.AhoRepoApeCuenta_sp' Puede moverla o quitarla según sea necesario.
            this.AhoRepoApeCuenta_spTableAdapter.Fill(this.AhorrosDataSet.AhoRepoApeCuenta_sp);

            this.reportViewer1.RefreshReport();
        }
    }
}
