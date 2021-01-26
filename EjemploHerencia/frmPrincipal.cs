using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploHerencia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Ticket[] ticketes = new Ticket[4];            

            ticketes[0] = new TicketGeneral(16000);
            ticketes[1] = new TicketPalco(24000);
            ticketes[2] = new TicketVIP(35000);
            ticketes[3] = new TicketPalcoDePie(50000);

            cmbTicketes.DataSource = ticketes;
            // DisplayMember indica cual propiedad se muestra en el combo
            cmbTicketes.DisplayMember = "Nombre";
            // ValueMember indica la propiedad oculta que tiene un valor
            cmbTicketes.ValueMember = "Valor";
        }

        private void cmbTicketes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ticket seleccionado = cmbTicketes.SelectedItem as Ticket;
            Ticket seleccionado = (Ticket)cmbTicketes.SelectedItem; // Igual
            
            if (seleccionado != null)
            {
                lblMonto.Text = seleccionado.Valor.ToString("C");
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Ticket seleccionado = cmbTicketes.SelectedItem as Ticket;

           
            if (seleccionado != null)
            {
                lbTicketesVendidos.Items.Add(seleccionado);
            }
        }

        private void btnComision_Click(object sender, EventArgs e)
        {            
            Ticket seleccionado = lbTicketesVendidos.SelectedItem as Ticket;

            //if(typeof(TicketGeneral) == seleccionado.GetType())
            //if(seleccionado is TicketGeneral)

            if (seleccionado != null)
            {
                seleccionado.Costo = 2;
                double d = seleccionado.Costo;

                lblComision.Text = seleccionado.CalcularComision().ToString("C");
            }
        }
    }
}
