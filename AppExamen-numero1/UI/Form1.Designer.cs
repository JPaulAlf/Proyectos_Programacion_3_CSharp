namespace appExamen_JohnPaul_Alfaro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblfechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGrande = new System.Windows.Forms.DataGridView();
            this.wbBuscador = new System.Windows.Forms.WebBrowser();
            this.dgvPequenno = new System.Windows.Forms.DataGridView();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitCoins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnCalcular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPequenno)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnCalcular,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblfechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblfechaHora
            // 
            this.lblfechaHora.Name = "lblfechaHora";
            this.lblfechaHora.Size = new System.Drawing.Size(146, 17);
            this.lblfechaHora.Text = "FECHA : HORA : MINUTOS";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvGrande);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbBuscador);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPequenno);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 501);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvGrande
            // 
            this.dgvGrande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrande.Location = new System.Drawing.Point(0, 0);
            this.dgvGrande.Name = "dgvGrande";
            this.dgvGrande.Size = new System.Drawing.Size(443, 501);
            this.dgvGrande.TabIndex = 0;
            // 
            // wbBuscador
            // 
            this.wbBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBuscador.Location = new System.Drawing.Point(3, 0);
            this.wbBuscador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBuscador.Name = "wbBuscador";
            this.wbBuscador.Size = new System.Drawing.Size(397, 351);
            this.wbBuscador.TabIndex = 2;
            // 
            // dgvPequenno
            // 
            this.dgvPequenno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPequenno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MontoTotal,
            this.BitCoins});
            this.dgvPequenno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPequenno.Location = new System.Drawing.Point(3, 351);
            this.dgvPequenno.Name = "dgvPequenno";
            this.dgvPequenno.Size = new System.Drawing.Size(397, 150);
            this.dgvPequenno.TabIndex = 1;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // BitCoins
            // 
            this.BitCoins.HeaderText = "BitCoins";
            this.BitCoins.Name = "BitCoins";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 501);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Image = global::UTN.Winform.Examen1.LogiCargo.Properties.Resources.nuevo1;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::UTN.Winform.Examen1.LogiCargo.Properties.Resources.calcolatrice_icon_png_5;
            this.btnCalcular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 49);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Winform.Examen1.LogiCargo.Properties.Resources.gnome_session_halt;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 49);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 575);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPequenno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnCalcular;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel lblfechaHora;
        private System.Windows.Forms.DataGridView dgvGrande;
        private System.Windows.Forms.WebBrowser wbBuscador;
        private System.Windows.Forms.DataGridView dgvPequenno;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitCoins;
    }
}

