namespace EjemploHerencia
{
    partial class frmPrincipal
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
            this.cmbTicketes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lbTicketesVendidos = new System.Windows.Forms.ListBox();
            this.btnComision = new System.Windows.Forms.Button();
            this.lblComision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTicketes
            // 
            this.cmbTicketes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketes.FormattingEnabled = true;
            this.cmbTicketes.Location = new System.Drawing.Point(184, 23);
            this.cmbTicketes.Name = "cmbTicketes";
            this.cmbTicketes.Size = new System.Drawing.Size(229, 21);
            this.cmbTicketes.TabIndex = 0;
            this.cmbTicketes.SelectedIndexChanged += new System.EventHandler(this.cmbTicketes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el Tipo de Ticket";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(213, 106);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Red;
            this.lblMonto.Location = new System.Drawing.Point(168, 66);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(165, 23);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTicketesVendidos
            // 
            this.lbTicketesVendidos.FormattingEnabled = true;
            this.lbTicketesVendidos.Location = new System.Drawing.Point(23, 148);
            this.lbTicketesVendidos.Name = "lbTicketesVendidos";
            this.lbTicketesVendidos.Size = new System.Drawing.Size(191, 186);
            this.lbTicketesVendidos.TabIndex = 4;
            // 
            // btnComision
            // 
            this.btnComision.Location = new System.Drawing.Point(220, 311);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(75, 23);
            this.btnComision.TabIndex = 5;
            this.btnComision.Text = "Ver comision";
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // lblComision
            // 
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblComision.Location = new System.Drawing.Point(310, 310);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(165, 23);
            this.lblComision.TabIndex = 6;
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.btnComision);
            this.Controls.Add(this.lbTicketesVendidos);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTicketes);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herencia";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTicketes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ListBox lbTicketesVendidos;
        private System.Windows.Forms.Button btnComision;
        private System.Windows.Forms.Label lblComision;
    }
}

