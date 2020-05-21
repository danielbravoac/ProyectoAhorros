namespace Reportes
{
    partial class frmAperturaCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AhorrosDataSet = new Reportes.AhorrosDataSet();
            this.AhoRepoApeCuenta_spBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AhoRepoApeCuenta_spTableAdapter = new Reportes.AhorrosDataSetTableAdapters.AhoRepoApeCuenta_spTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AhorrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AhoRepoApeCuenta_spBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AhoRepoApeCuenta_spBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.rptAperturaCuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // AhorrosDataSet
            // 
            this.AhorrosDataSet.DataSetName = "AhorrosDataSet";
            this.AhorrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AhoRepoApeCuenta_spBindingSource
            // 
            this.AhoRepoApeCuenta_spBindingSource.DataMember = "AhoRepoApeCuenta_sp";
            this.AhoRepoApeCuenta_spBindingSource.DataSource = this.AhorrosDataSet;
            // 
            // AhoRepoApeCuenta_spTableAdapter
            // 
            this.AhoRepoApeCuenta_spTableAdapter.ClearBeforeFill = true;
            // 
            // frmAperturaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 397);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAperturaCuenta";
            this.ShowIcon = false;
            this.Text = "Voucher de Apertura";
            this.Load += new System.EventHandler(this.frmAperturaCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AhorrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AhoRepoApeCuenta_spBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AhoRepoApeCuenta_spBindingSource;
        private AhorrosDataSet AhorrosDataSet;
        private AhorrosDataSetTableAdapters.AhoRepoApeCuenta_spTableAdapter AhoRepoApeCuenta_spTableAdapter;
    }
}