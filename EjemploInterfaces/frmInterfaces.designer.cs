namespace EjemploInterfaces
{
    partial class frmInterfaces
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.lbCuentasAhorros = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTransferencia = new System.Windows.Forms.RadioButton();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioEgreso = new System.Windows.Forms.RadioButton();
            this.radioIngreso = new System.Windows.Forms.RadioButton();
            this.lbCuentasCorrientes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoAhorro = new System.Windows.Forms.TextBox();
            this.btnDesSelecAhorros = new System.Windows.Forms.Button();
            this.btnDesSelecCorriente = new System.Windows.Forms.Button();
            this.txtSaldoCorriente = new System.Windows.Forms.TextBox();
            this.btnSentidoTrans = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(434, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el Tipo de Cuenta";
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Location = new System.Drawing.Point(179, 12);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(229, 21);
            this.cmbCuentas.TabIndex = 4;
            // 
            // lbCuentasAhorros
            // 
            this.lbCuentasAhorros.FormattingEnabled = true;
            this.lbCuentasAhorros.Location = new System.Drawing.Point(20, 83);
            this.lbCuentasAhorros.Name = "lbCuentasAhorros";
            this.lbCuentasAhorros.Size = new System.Drawing.Size(191, 199);
            this.lbCuentasAhorros.TabIndex = 7;
            this.lbCuentasAhorros.SelectedIndexChanged += new System.EventHandler(this.lbCuentas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSentidoTrans);
            this.groupBox1.Controls.Add(this.radioTransferencia);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioEgreso);
            this.groupBox1.Controls.Add(this.radioIngreso);
            this.groupBox1.Location = new System.Drawing.Point(229, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transacciones";
            // 
            // radioTransferencia
            // 
            this.radioTransferencia.AutoSize = true;
            this.radioTransferencia.Location = new System.Drawing.Point(153, 31);
            this.radioTransferencia.Name = "radioTransferencia";
            this.radioTransferencia.Size = new System.Drawing.Size(90, 17);
            this.radioTransferencia.TabIndex = 8;
            this.radioTransferencia.Text = "Transferencia";
            this.radioTransferencia.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(90, 107);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(64, 23);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(67, 68);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(113, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // radioEgreso
            // 
            this.radioEgreso.AutoSize = true;
            this.radioEgreso.Location = new System.Drawing.Point(90, 31);
            this.radioEgreso.Name = "radioEgreso";
            this.radioEgreso.Size = new System.Drawing.Size(53, 17);
            this.radioEgreso.TabIndex = 1;
            this.radioEgreso.Text = "Retiro";
            this.radioEgreso.UseVisualStyleBackColor = true;
            // 
            // radioIngreso
            // 
            this.radioIngreso.AutoSize = true;
            this.radioIngreso.Checked = true;
            this.radioIngreso.Location = new System.Drawing.Point(6, 31);
            this.radioIngreso.Name = "radioIngreso";
            this.radioIngreso.Size = new System.Drawing.Size(67, 17);
            this.radioIngreso.TabIndex = 0;
            this.radioIngreso.TabStop = true;
            this.radioIngreso.Text = "Deposito";
            this.radioIngreso.UseVisualStyleBackColor = true;
            // 
            // lbCuentasCorrientes
            // 
            this.lbCuentasCorrientes.FormattingEnabled = true;
            this.lbCuentasCorrientes.Location = new System.Drawing.Point(507, 83);
            this.lbCuentasCorrientes.Name = "lbCuentasCorrientes";
            this.lbCuentasCorrientes.Size = new System.Drawing.Size(191, 199);
            this.lbCuentasCorrientes.TabIndex = 11;
            this.lbCuentasCorrientes.SelectedIndexChanged += new System.EventHandler(this.lbCuentasCorrientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ahorro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Corriente";
            // 
            // txtSaldoAhorro
            // 
            this.txtSaldoAhorro.AcceptsReturn = true;
            this.txtSaldoAhorro.Location = new System.Drawing.Point(98, 57);
            this.txtSaldoAhorro.Name = "txtSaldoAhorro";
            this.txtSaldoAhorro.ReadOnly = true;
            this.txtSaldoAhorro.Size = new System.Drawing.Size(113, 20);
            this.txtSaldoAhorro.TabIndex = 10;
            // 
            // btnDesSelecAhorros
            // 
            this.btnDesSelecAhorros.Location = new System.Drawing.Point(50, 288);
            this.btnDesSelecAhorros.Name = "btnDesSelecAhorros";
            this.btnDesSelecAhorros.Size = new System.Drawing.Size(128, 23);
            this.btnDesSelecAhorros.TabIndex = 14;
            this.btnDesSelecAhorros.Text = "Quitar selección";
            this.btnDesSelecAhorros.UseVisualStyleBackColor = true;
            this.btnDesSelecAhorros.Click += new System.EventHandler(this.btnDesSelecAhorros_Click);
            // 
            // btnDesSelecCorriente
            // 
            this.btnDesSelecCorriente.Location = new System.Drawing.Point(544, 288);
            this.btnDesSelecCorriente.Name = "btnDesSelecCorriente";
            this.btnDesSelecCorriente.Size = new System.Drawing.Size(128, 23);
            this.btnDesSelecCorriente.TabIndex = 15;
            this.btnDesSelecCorriente.Text = "Quitar selección";
            this.btnDesSelecCorriente.UseVisualStyleBackColor = true;
            this.btnDesSelecCorriente.Click += new System.EventHandler(this.btnDesSelecCorriente_Click);
            // 
            // txtSaldoCorriente
            // 
            this.txtSaldoCorriente.AcceptsReturn = true;
            this.txtSaldoCorriente.Location = new System.Drawing.Point(585, 57);
            this.txtSaldoCorriente.Name = "txtSaldoCorriente";
            this.txtSaldoCorriente.ReadOnly = true;
            this.txtSaldoCorriente.Size = new System.Drawing.Size(113, 20);
            this.txtSaldoCorriente.TabIndex = 16;
            // 
            // btnSentidoTrans
            // 
            this.btnSentidoTrans.Location = new System.Drawing.Point(6, 150);
            this.btnSentidoTrans.Name = "btnSentidoTrans";
            this.btnSentidoTrans.Size = new System.Drawing.Size(237, 23);
            this.btnSentidoTrans.TabIndex = 9;
            this.btnSentidoTrans.Text = "Transferir a Cuenta Corriente >>";
            this.btnSentidoTrans.UseVisualStyleBackColor = true;
            this.btnSentidoTrans.Click += new System.EventHandler(this.btnSentidoTrans_Click);
            // 
            // frmInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.txtSaldoCorriente);
            this.Controls.Add(this.txtSaldoAhorro);
            this.Controls.Add(this.btnDesSelecCorriente);
            this.Controls.Add(this.btnDesSelecAhorros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCuentasCorrientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCuentasAhorros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCuentas);
            this.Name = "frmInterfaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaces";
            this.Load += new System.EventHandler(this.frmInterfaces_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCuentas;
        private System.Windows.Forms.ListBox lbCuentasAhorros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioEgreso;
        private System.Windows.Forms.RadioButton radioIngreso;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.RadioButton radioTransferencia;
        private System.Windows.Forms.ListBox lbCuentasCorrientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldoAhorro;
        private System.Windows.Forms.Button btnDesSelecAhorros;
        private System.Windows.Forms.Button btnDesSelecCorriente;
        private System.Windows.Forms.Button btnSentidoTrans;
        private System.Windows.Forms.TextBox txtSaldoCorriente;
    }
}