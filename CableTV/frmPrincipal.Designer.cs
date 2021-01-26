namespace Quiz2.CableTV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPaquetes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudCantidadTV = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaNace = new System.Windows.Forms.DateTimePicker();
            this.cmbZonas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTelefono = new System.Windows.Forms.CheckBox();
            this.chkDigital = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTigoStar = new System.Windows.Forms.RadioButton();
            this.rbtCableTica = new System.Windows.Forms.RadioButton();
            this.rbtTeleCable = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadTV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "telecable.PNG");
            this.imageList.Images.SetKeyName(1, "tigo.PNG");
            this.imageList.Images.SetKeyName(2, "cabletica.PNG");
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(298, 501);
            this.webBrowser.TabIndex = 10;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnCotizar);
            this.splitContainer.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer.Size = new System.Drawing.Size(704, 501);
            this.splitContainer.SplitterDistance = 402;
            this.splitContainer.TabIndex = 11;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(134, 458);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(124, 32);
            this.btnCotizar.TabIndex = 11;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPaquetes);
            this.groupBox4.Location = new System.Drawing.Point(203, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 105);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paquetes";
            // 
            // lstPaquetes
            // 
            this.lstPaquetes.DisplayMember = "Descripcion";
            this.lstPaquetes.FormattingEnabled = true;
            this.lstPaquetes.ItemHeight = 16;
            this.lstPaquetes.Location = new System.Drawing.Point(14, 21);
            this.lstPaquetes.Name = "lstPaquetes";
            this.lstPaquetes.Size = new System.Drawing.Size(157, 68);
            this.lstPaquetes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudCantidadTV);
            this.groupBox3.Controls.Add(this.dtpFechaNace);
            this.groupBox3.Controls.Add(this.cmbZonas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.mtxId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 222);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // nudCantidadTV
            // 
            this.nudCantidadTV.Location = new System.Drawing.Point(163, 141);
            this.nudCantidadTV.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidadTV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadTV.Name = "nudCantidadTV";
            this.nudCantidadTV.Size = new System.Drawing.Size(83, 22);
            this.nudCantidadTV.TabIndex = 9;
            this.nudCantidadTV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFechaNace
            // 
            this.dtpFechaNace.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNace.Location = new System.Drawing.Point(163, 105);
            this.dtpFechaNace.Name = "dtpFechaNace";
            this.dtpFechaNace.Size = new System.Drawing.Size(157, 22);
            this.dtpFechaNace.TabIndex = 5;
            // 
            // cmbZonas
            // 
            this.cmbZonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonas.FormattingEnabled = true;
            this.cmbZonas.Location = new System.Drawing.Point(163, 177);
            this.cmbZonas.Name = "cmbZonas";
            this.cmbZonas.Size = new System.Drawing.Size(157, 24);
            this.cmbZonas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de TV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zona";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // mtxId
            // 
            this.mtxId.Location = new System.Drawing.Point(163, 33);
            this.mtxId.Mask = "0-0000-0000";
            this.mtxId.Name = "mtxId";
            this.mtxId.Size = new System.Drawing.Size(157, 22);
            this.mtxId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTelefono);
            this.groupBox2.Controls.Add(this.chkDigital);
            this.groupBox2.Controls.Add(this.chkInternet);
            this.groupBox2.Location = new System.Drawing.Point(12, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 105);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionales";
            // 
            // chkTelefono
            // 
            this.chkTelefono.AutoSize = true;
            this.chkTelefono.Location = new System.Drawing.Point(52, 24);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(81, 20);
            this.chkTelefono.TabIndex = 2;
            this.chkTelefono.Text = "Teléfono";
            this.chkTelefono.UseVisualStyleBackColor = true;
            // 
            // chkDigital
            // 
            this.chkDigital.AutoSize = true;
            this.chkDigital.Location = new System.Drawing.Point(52, 76);
            this.chkDigital.Name = "chkDigital";
            this.chkDigital.Size = new System.Drawing.Size(65, 20);
            this.chkDigital.TabIndex = 1;
            this.chkDigital.Text = "Digital";
            this.chkDigital.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(52, 50);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(70, 20);
            this.chkInternet.TabIndex = 0;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTigoStar);
            this.groupBox1.Controls.Add(this.rbtCableTica);
            this.groupBox1.Controls.Add(this.rbtTeleCable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 101);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            // 
            // rbtTigoStar
            // 
            this.rbtTigoStar.AutoSize = true;
            this.rbtTigoStar.ImageIndex = 1;
            this.rbtTigoStar.ImageList = this.imageList;
            this.rbtTigoStar.Location = new System.Drawing.Point(254, 18);
            this.rbtTigoStar.Name = "rbtTigoStar";
            this.rbtTigoStar.Size = new System.Drawing.Size(93, 64);
            this.rbtTigoStar.TabIndex = 2;
            this.rbtTigoStar.TabStop = true;
            this.rbtTigoStar.Text = " ";
            this.rbtTigoStar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtTigoStar.UseVisualStyleBackColor = true;
            this.rbtTigoStar.CheckedChanged += new System.EventHandler(this.rbtTigoStar_CheckedChanged);
            // 
            // rbtCableTica
            // 
            this.rbtCableTica.AutoSize = true;
            this.rbtCableTica.ImageKey = "cabletica.PNG";
            this.rbtCableTica.ImageList = this.imageList;
            this.rbtCableTica.Location = new System.Drawing.Point(142, 18);
            this.rbtCableTica.Name = "rbtCableTica";
            this.rbtCableTica.Size = new System.Drawing.Size(93, 64);
            this.rbtCableTica.TabIndex = 1;
            this.rbtCableTica.TabStop = true;
            this.rbtCableTica.Text = " ";
            this.rbtCableTica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtCableTica.UseVisualStyleBackColor = true;
            this.rbtCableTica.CheckedChanged += new System.EventHandler(this.rbtCableTica_CheckedChanged);
            // 
            // rbtTeleCable
            // 
            this.rbtTeleCable.AutoSize = true;
            this.rbtTeleCable.ImageIndex = 0;
            this.rbtTeleCable.ImageList = this.imageList;
            this.rbtTeleCable.Location = new System.Drawing.Point(30, 18);
            this.rbtTeleCable.Name = "rbtTeleCable";
            this.rbtTeleCable.Size = new System.Drawing.Size(93, 64);
            this.rbtTeleCable.TabIndex = 0;
            this.rbtTeleCable.TabStop = true;
            this.rbtTeleCable.Text = " ";
            this.rbtTeleCable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtTeleCable.UseVisualStyleBackColor = true;
            this.rbtTeleCable.CheckedChanged += new System.EventHandler(this.rbtTeleCable_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cable TV";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadTV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstPaquetes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudCantidadTV;
        private System.Windows.Forms.DateTimePicker dtpFechaNace;
        private System.Windows.Forms.ComboBox cmbZonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTelefono;
        private System.Windows.Forms.CheckBox chkDigital;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTigoStar;
        private System.Windows.Forms.RadioButton rbtCableTica;
        private System.Windows.Forms.RadioButton rbtTeleCable;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

