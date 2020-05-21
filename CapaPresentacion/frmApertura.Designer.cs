namespace CapaPresentacion
{
    partial class frmApertura
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
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatosCuenta = new System.Windows.Forms.GroupBox();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.nudMontoApertura = new System.Windows.Forms.NumericUpDown();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.lblMontoApertura = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDatosCliente.SuspendLayout();
            this.grpDatosCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApertura)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.txtDocumento);
            this.grpDatosCliente.Controls.Add(this.txtApellidoMat);
            this.grpDatosCliente.Controls.Add(this.txtApellidoPat);
            this.grpDatosCliente.Controls.Add(this.txtNombre);
            this.grpDatosCliente.Controls.Add(this.btnBuscarCliente);
            this.grpDatosCliente.Controls.Add(this.lblApMat);
            this.grpDatosCliente.Controls.Add(this.lblApPat);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.label1);
            this.grpDatosCliente.Location = new System.Drawing.Point(411, 30);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(300, 202);
            this.grpDatosCliente.TabIndex = 4;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos de Cliente";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(16, 37);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(165, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.Enabled = false;
            this.txtApellidoMat.Location = new System.Drawing.Point(16, 172);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(278, 20);
            this.txtApellidoMat.TabIndex = 3;
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.Enabled = false;
            this.txtApellidoPat.Location = new System.Drawing.Point(16, 128);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(278, 20);
            this.txtApellidoPat.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(16, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(187, 29);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(107, 34);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Location = new System.Drawing.Point(13, 156);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(86, 13);
            this.lblApMat.TabIndex = 1;
            this.lblApMat.Text = "Apellido Materno";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Location = new System.Drawing.Point(13, 112);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(84, 13);
            this.lblApPat.TabIndex = 1;
            this.lblApPat.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // grpDatosCuenta
            // 
            this.grpDatosCuenta.Controls.Add(this.dtpFechaApertura);
            this.grpDatosCuenta.Controls.Add(this.nudMontoApertura);
            this.grpDatosCuenta.Controls.Add(this.cmbMoneda);
            this.grpDatosCuenta.Controls.Add(this.cmbTipoCuenta);
            this.grpDatosCuenta.Controls.Add(this.lblFechaApertura);
            this.grpDatosCuenta.Controls.Add(this.lblMontoApertura);
            this.grpDatosCuenta.Controls.Add(this.lblTipoMoneda);
            this.grpDatosCuenta.Controls.Add(this.lblTipoCuenta);
            this.grpDatosCuenta.Location = new System.Drawing.Point(71, 30);
            this.grpDatosCuenta.Name = "grpDatosCuenta";
            this.grpDatosCuenta.Size = new System.Drawing.Size(300, 202);
            this.grpDatosCuenta.TabIndex = 5;
            this.grpDatosCuenta.TabStop = false;
            this.grpDatosCuenta.Text = "Datos de Cuenta";
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaApertura.Location = new System.Drawing.Point(104, 169);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaApertura.TabIndex = 3;
            // 
            // nudMontoApertura
            // 
            this.nudMontoApertura.DecimalPlaces = 2;
            this.nudMontoApertura.Location = new System.Drawing.Point(104, 131);
            this.nudMontoApertura.Name = "nudMontoApertura";
            this.nudMontoApertura.Size = new System.Drawing.Size(180, 20);
            this.nudMontoApertura.TabIndex = 2;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(104, 86);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(180, 21);
            this.cmbMoneda.TabIndex = 0;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.Enabled = false;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(104, 39);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(180, 21);
            this.cmbTipoCuenta.TabIndex = 0;
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(6, 172);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(95, 13);
            this.lblFechaApertura.TabIndex = 1;
            this.lblFechaApertura.Text = "Fecha de Apertura";
            // 
            // lblMontoApertura
            // 
            this.lblMontoApertura.AutoSize = true;
            this.lblMontoApertura.Location = new System.Drawing.Point(6, 134);
            this.lblMontoApertura.Name = "lblMontoApertura";
            this.lblMontoApertura.Size = new System.Drawing.Size(95, 13);
            this.lblMontoApertura.TabIndex = 1;
            this.lblMontoApertura.Text = "Monto de Apertura";
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Location = new System.Drawing.Point(55, 90);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblTipoMoneda.TabIndex = 1;
            this.lblTipoMoneda.Text = "Moneda";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(21, 43);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuenta.TabIndex = 1;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(71, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(640, 69);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmApertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 354);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.grpDatosCuenta);
            this.Name = "frmApertura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura de Cuenta";
            this.Load += new System.EventHandler(this.frmApertura_Load);
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.grpDatosCuenta.ResumeLayout(false);
            this.grpDatosCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApertura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.TextBox txtApellidoMat;
        public System.Windows.Forms.TextBox txtApellidoPat;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatosCuenta;
        private System.Windows.Forms.NumericUpDown nudMontoApertura;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblMontoApertura;
        private System.Windows.Forms.Label lblTipoMoneda;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaApertura;
        private System.Windows.Forms.Label lblFechaApertura;
    }
}