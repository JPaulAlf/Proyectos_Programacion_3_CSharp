namespace UTN.Winform.Bebidas.UI
{
    partial class BebidasUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadGramosIngredientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chFresa = new System.Windows.Forms.CheckBox();
            this.chPapaya = new System.Windows.Forms.CheckBox();
            this.chPina = new System.Windows.Forms.CheckBox();
            this.chPera = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidadGramosLiquidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPolvo = new System.Windows.Forms.RadioButton();
            this.rdbLecheDescremada = new System.Windows.Forms.RadioButton();
            this.rdbLecheRegular = new System.Windows.Forms.RadioButton();
            this.rdbYogurt = new System.Windows.Forms.RadioButton();
            this.rdbAgua = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tlsEstadoCalorias = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsCostoBebida = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsCalorias = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadGramosIngredientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chFresa);
            this.groupBox1.Controls.Add(this.chPapaya);
            this.groupBox1.Controls.Add(this.chPina);
            this.groupBox1.Controls.Add(this.chPera);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGREDIENTES";
            // 
            // txtCantidadGramosIngredientes
            // 
            this.txtCantidadGramosIngredientes.Location = new System.Drawing.Point(130, 232);
            this.txtCantidadGramosIngredientes.Name = "txtCantidadGramosIngredientes";
            this.txtCantidadGramosIngredientes.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadGramosIngredientes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de gramos:";
            // 
            // chFresa
            // 
            this.chFresa.AutoSize = true;
            this.chFresa.Location = new System.Drawing.Point(22, 174);
            this.chFresa.Name = "chFresa";
            this.chFresa.Size = new System.Drawing.Size(52, 17);
            this.chFresa.TabIndex = 3;
            this.chFresa.Text = "Fresa";
            this.chFresa.UseVisualStyleBackColor = true;
            // 
            // chPapaya
            // 
            this.chPapaya.AutoSize = true;
            this.chPapaya.Location = new System.Drawing.Point(22, 130);
            this.chPapaya.Name = "chPapaya";
            this.chPapaya.Size = new System.Drawing.Size(62, 17);
            this.chPapaya.TabIndex = 2;
            this.chPapaya.Text = "Papaya";
            this.chPapaya.UseVisualStyleBackColor = true;
            // 
            // chPina
            // 
            this.chPina.AutoSize = true;
            this.chPina.Location = new System.Drawing.Point(22, 84);
            this.chPina.Name = "chPina";
            this.chPina.Size = new System.Drawing.Size(47, 17);
            this.chPina.TabIndex = 1;
            this.chPina.Text = "Pina";
            this.chPina.UseVisualStyleBackColor = true;
            // 
            // chPera
            // 
            this.chPera.AutoSize = true;
            this.chPera.Location = new System.Drawing.Point(22, 40);
            this.chPera.Name = "chPera";
            this.chPera.Size = new System.Drawing.Size(48, 17);
            this.chPera.TabIndex = 0;
            this.chPera.Text = "Pera";
            this.chPera.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidadGramosLiquidos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbPolvo);
            this.groupBox2.Controls.Add(this.rdbLecheDescremada);
            this.groupBox2.Controls.Add(this.rdbLecheRegular);
            this.groupBox2.Controls.Add(this.rdbYogurt);
            this.groupBox2.Controls.Add(this.rdbAgua);
            this.groupBox2.Location = new System.Drawing.Point(340, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LIQUIDOS";
            // 
            // txtCantidadGramosLiquidos
            // 
            this.txtCantidadGramosLiquidos.Location = new System.Drawing.Point(156, 229);
            this.txtCantidadGramosLiquidos.Name = "txtCantidadGramosLiquidos";
            this.txtCantidadGramosLiquidos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadGramosLiquidos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de gramos:";
            // 
            // rdbPolvo
            // 
            this.rdbPolvo.AutoSize = true;
            this.rdbPolvo.Location = new System.Drawing.Point(35, 130);
            this.rdbPolvo.Name = "rdbPolvo";
            this.rdbPolvo.Size = new System.Drawing.Size(52, 17);
            this.rdbPolvo.TabIndex = 4;
            this.rdbPolvo.TabStop = true;
            this.rdbPolvo.Text = "Polvo";
            this.rdbPolvo.UseVisualStyleBackColor = true;
            this.rdbPolvo.CheckedChanged += new System.EventHandler(this.rdbPolvo_CheckedChanged);
            // 
            // rdbLecheDescremada
            // 
            this.rdbLecheDescremada.AutoSize = true;
            this.rdbLecheDescremada.Location = new System.Drawing.Point(35, 109);
            this.rdbLecheDescremada.Name = "rdbLecheDescremada";
            this.rdbLecheDescremada.Size = new System.Drawing.Size(118, 17);
            this.rdbLecheDescremada.TabIndex = 3;
            this.rdbLecheDescremada.TabStop = true;
            this.rdbLecheDescremada.Text = "Leche Descremada";
            this.rdbLecheDescremada.UseVisualStyleBackColor = true;
            // 
            // rdbLecheRegular
            // 
            this.rdbLecheRegular.AutoSize = true;
            this.rdbLecheRegular.Location = new System.Drawing.Point(35, 86);
            this.rdbLecheRegular.Name = "rdbLecheRegular";
            this.rdbLecheRegular.Size = new System.Drawing.Size(95, 17);
            this.rdbLecheRegular.TabIndex = 2;
            this.rdbLecheRegular.TabStop = true;
            this.rdbLecheRegular.Text = "Leche Regular";
            this.rdbLecheRegular.UseVisualStyleBackColor = true;
            // 
            // rdbYogurt
            // 
            this.rdbYogurt.AutoSize = true;
            this.rdbYogurt.Location = new System.Drawing.Point(35, 63);
            this.rdbYogurt.Name = "rdbYogurt";
            this.rdbYogurt.Size = new System.Drawing.Size(56, 17);
            this.rdbYogurt.TabIndex = 1;
            this.rdbYogurt.TabStop = true;
            this.rdbYogurt.Text = "Yogurt";
            this.rdbYogurt.UseVisualStyleBackColor = true;
            // 
            // rdbAgua
            // 
            this.rdbAgua.AutoSize = true;
            this.rdbAgua.Location = new System.Drawing.Point(35, 40);
            this.rdbAgua.Name = "rdbAgua";
            this.rdbAgua.Size = new System.Drawing.Size(50, 17);
            this.rdbAgua.TabIndex = 0;
            this.rdbAgua.TabStop = true;
            this.rdbAgua.Text = "Agua";
            this.rdbAgua.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(704, 118);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(704, 160);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(704, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.tlsEstadoCalorias,
            this.toolStripStatusLabel2,
            this.tlsCostoBebida,
            this.toolStripStatusLabel4,
            this.tlsCalorias});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1.Text = "Estado Calorias";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 2000;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 2000;
            // 
            // tlsEstadoCalorias
            // 
            this.tlsEstadoCalorias.ForeColor = System.Drawing.Color.Red;
            this.tlsEstadoCalorias.Name = "tlsEstadoCalorias";
            this.tlsEstadoCalorias.Size = new System.Drawing.Size(17, 17);
            this.tlsEstadoCalorias.Text = "--";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel2.Text = "CostoBebida";
            // 
            // tlsCostoBebida
            // 
            this.tlsCostoBebida.ForeColor = System.Drawing.Color.Red;
            this.tlsCostoBebida.Name = "tlsCostoBebida";
            this.tlsCostoBebida.Size = new System.Drawing.Size(17, 17);
            this.tlsCostoBebida.Text = "--";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel4.Text = "Calorias";
            // 
            // tlsCalorias
            // 
            this.tlsCalorias.ForeColor = System.Drawing.Color.Red;
            this.tlsCalorias.Name = "tlsCalorias";
            this.tlsCalorias.Size = new System.Drawing.Size(17, 17);
            this.tlsCalorias.Text = "--";
            // 
            // BebidasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BebidasUI";
            this.Text = "BebidasUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tlsEstadoCalorias;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tlsCostoBebida;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tlsCalorias;
        private System.Windows.Forms.TextBox txtCantidadGramosIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chFresa;
        private System.Windows.Forms.CheckBox chPapaya;
        private System.Windows.Forms.CheckBox chPina;
        private System.Windows.Forms.CheckBox chPera;
        private System.Windows.Forms.TextBox txtCantidadGramosLiquidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPolvo;
        private System.Windows.Forms.RadioButton rdbLecheDescremada;
        private System.Windows.Forms.RadioButton rdbLecheRegular;
        private System.Windows.Forms.RadioButton rdbYogurt;
        private System.Windows.Forms.RadioButton rdbAgua;
    }
}