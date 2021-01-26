namespace form
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProducto1 = new System.Windows.Forms.Button();
            this.btnProducto2 = new System.Windows.Forms.Button();
            this.btnProducto3 = new System.Windows.Forms.Button();
            this.btnProducto4 = new System.Windows.Forms.Button();
            this.lstSnacksSeleccionados = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMontoXPagar = new System.Windows.Forms.TextBox();
            this.mskPagoRealizado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(115, 28);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(213, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProducto1
            // 
            this.btnProducto1.Location = new System.Drawing.Point(12, 163);
            this.btnProducto1.Name = "btnProducto1";
            this.btnProducto1.Size = new System.Drawing.Size(75, 23);
            this.btnProducto1.TabIndex = 3;
            this.btnProducto1.Text = "CHOCOLATE";
            this.btnProducto1.UseVisualStyleBackColor = true;
            this.btnProducto1.Click += new System.EventHandler(this.btnProducto1_Click);
            // 
            // btnProducto2
            // 
            this.btnProducto2.Location = new System.Drawing.Point(124, 163);
            this.btnProducto2.Name = "btnProducto2";
            this.btnProducto2.Size = new System.Drawing.Size(75, 23);
            this.btnProducto2.TabIndex = 4;
            this.btnProducto2.Text = "CANDY";
            this.btnProducto2.UseVisualStyleBackColor = true;
            this.btnProducto2.Click += new System.EventHandler(this.btnProducto2_Click);
            // 
            // btnProducto3
            // 
            this.btnProducto3.Location = new System.Drawing.Point(12, 223);
            this.btnProducto3.Name = "btnProducto3";
            this.btnProducto3.Size = new System.Drawing.Size(75, 23);
            this.btnProducto3.TabIndex = 5;
            this.btnProducto3.Text = "CHIP";
            this.btnProducto3.UseVisualStyleBackColor = true;
            this.btnProducto3.Click += new System.EventHandler(this.btnProducto3_Click);
            // 
            // btnProducto4
            // 
            this.btnProducto4.Location = new System.Drawing.Point(124, 223);
            this.btnProducto4.Name = "btnProducto4";
            this.btnProducto4.Size = new System.Drawing.Size(75, 23);
            this.btnProducto4.TabIndex = 6;
            this.btnProducto4.Text = "DRINK";
            this.btnProducto4.UseVisualStyleBackColor = true;
            this.btnProducto4.Click += new System.EventHandler(this.btnProducto4_Click);
            // 
            // lstSnacksSeleccionados
            // 
            this.lstSnacksSeleccionados.FormattingEnabled = true;
            this.lstSnacksSeleccionados.Location = new System.Drawing.Point(280, 91);
            this.lstSnacksSeleccionados.Name = "lstSnacksSeleccionados";
            this.lstSnacksSeleccionados.Size = new System.Drawing.Size(203, 160);
            this.lstSnacksSeleccionados.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(557, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMontoXPagar
            // 
            this.txtMontoXPagar.Location = new System.Drawing.Point(352, 281);
            this.txtMontoXPagar.Name = "txtMontoXPagar";
            this.txtMontoXPagar.Size = new System.Drawing.Size(100, 20);
            this.txtMontoXPagar.TabIndex = 9;
            // 
            // mskPagoRealizado
            // 
            this.mskPagoRealizado.Location = new System.Drawing.Point(352, 307);
            this.mskPagoRealizado.Name = "mskPagoRealizado";
            this.mskPagoRealizado.Size = new System.Drawing.Size(100, 20);
            this.mskPagoRealizado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PAGAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PAGO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskPagoRealizado);
            this.Controls.Add(this.txtMontoXPagar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstSnacksSeleccionados);
            this.Controls.Add(this.btnProducto4);
            this.Controls.Add(this.btnProducto3);
            this.Controls.Add(this.btnProducto2);
            this.Controls.Add(this.btnProducto1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProducto1;
        private System.Windows.Forms.Button btnProducto2;
        private System.Windows.Forms.Button btnProducto3;
        private System.Windows.Forms.Button btnProducto4;
        private System.Windows.Forms.ListBox lstSnacksSeleccionados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtMontoXPagar;
        private System.Windows.Forms.TextBox mskPagoRealizado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

