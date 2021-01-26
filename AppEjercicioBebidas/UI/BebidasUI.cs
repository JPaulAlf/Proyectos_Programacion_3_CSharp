using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Bebidas.Class;
using UTN.Winform.Bebidas.Factory;
using UTN.Winform.Bebidas.Gestor;
using UTN.Winform.Bebidas.Interface;

namespace UTN.Winform.Bebidas.UI
{
    public partial class BebidasUI : Form
    {
        //private Liquido oLiquido=null;
       // private Ingrediente oIngrediente = null;
        Gestor.Gestor gestor = Gestor.Gestor.GetInstance();
       // gestor = Gestor.Gestor.GetInstance();

        public BebidasUI()
        {
            InitializeComponent();
            this.txtCantidadGramosLiquidos.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            Ingrediente oIngrediente = null;
            Liquido oLiquido = null;
            try
            {
                FactoryIngrediente factory = new FactoryIngrediente();
                //gestor = Gestor.Gestor.GetInstance();

                #region Ingredientes
                if (this.chFresa.Checked)
                {
                     oIngrediente = factory.CrearIngrediente(TipoIngrediente.Fresa);
                    oIngrediente.Gramo = Convert.ToInt32(this.txtCantidadGramosIngredientes.Text);
                    oIngrediente.Descripcion = "FRESA";
                    gestor.AgregaIngrediente(oIngrediente);
                }
                if (this.chPina.Checked)
                {
                    oIngrediente = factory.CrearIngrediente(TipoIngrediente.Pina);
                    oIngrediente.Gramo = Convert.ToInt32(this.txtCantidadGramosIngredientes.Text);
                    oIngrediente.Descripcion = "PINA";
                    gestor.AgregaIngrediente(oIngrediente);
                }
                if (this.chPapaya.Checked)
                {
                    oIngrediente = factory.CrearIngrediente(TipoIngrediente.Papaya);
                    oIngrediente.Gramo = Convert.ToInt32(this.txtCantidadGramosIngredientes.Text);
                    oIngrediente.Descripcion = "PAPAYA";
                    gestor.AgregaIngrediente(oIngrediente);
                }
                if (this.chPera.Checked)
                {
                     oIngrediente = factory.CrearIngrediente(TipoIngrediente.Pera);
                    oIngrediente.Gramo = Convert.ToInt32(this.txtCantidadGramosIngredientes.Text);
                    oIngrediente.Descripcion = "PERA";
                    gestor.AgregaIngrediente(oIngrediente);
                }
                #endregion

                #region LIQUIDO
                if (this.rdbAgua.Checked)
                {
                     oLiquido = new Agua();
                    oLiquido.Descripcion = "AGUA";
                    gestor.AsignarLiquido(oLiquido);
                }
                if (this.rdbYogurt.Checked)
                {
                     oLiquido = new Yogurt();
                    oLiquido.Descripcion = "YOGURT";
                    gestor.AsignarLiquido(oLiquido);
                }
                if (this.rdbLecheRegular.Checked)
                {
                     oLiquido = new Regular();
                    oLiquido.Descripcion = "LECHE REGULAR";
                    gestor.AsignarLiquido(oLiquido);
                }
                if (this.rdbLecheDescremada.Checked)
                {
                     oLiquido = new Descremada();
                    oLiquido.Descripcion = "LECHE DESCREMADA";
                    gestor.AsignarLiquido(oLiquido);
                }
                if (this.rdbPolvo.Checked)
                {
                     oLiquido = new Polvo();
                    (oLiquido as IGramo).AsignarGramo(Convert.ToInt32(this.txtCantidadGramosLiquidos.Text));
                    gestor.AsignarLiquido(oLiquido);
                }
                #endregion

                this.tlsEstadoCalorias.Text = ( this.toolStripProgressBar1.Value - gestor.Calorias() ).ToString();
                this.tlsCostoBebida.Text = Convert.ToString( gestor.Costo() );
                this.tlsCalorias.Text = gestor.Calorias().ToString();

            }
            catch (Exception error)
            {
                msg.AppendFormat("Ha ocurrido un error, a continuación se explica");
                msg.AppendFormat("Mensaje {0}\n", error.Message);
                msg.AppendFormat("Data {0}\n", error.Data);
                msg.AppendFormat("Source {0}\n", error.Source);
                msg.AppendFormat("StackTrace {0}\n", error.StackTrace);
                MessageBox.Show(msg.ToString(), "Atención",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                string msj = gestor.ToString();
                Factura f = new Factura();
                f.Salvar(msj);

                Process.Start("iexplore.exe", @"c:\temp\facturabebida.xml");

            }
            catch (Exception error)
            {
                msg.AppendFormat("Ha ocurrido un error, a continuación se explica");
                msg.AppendFormat("Mensaje {0}\n", error.Message);
                msg.AppendFormat("Data {0}\n", error.Data);
                msg.AppendFormat("Source {0}\n", error.Source);
                msg.AppendFormat("StackTrace {0}\n", error.StackTrace);
                MessageBox.Show(msg.ToString(), "Atención",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            try
            {


                Application.Exit();


            }
            catch (Exception error)
            {
                msg.AppendFormat("Ha ocurrido un error, a continuación se explica");
                msg.AppendFormat("Mensaje {0}\n", error.Message);
                msg.AppendFormat("Data {0}\n", error.Data);
                msg.AppendFormat("Source {0}\n", error.Source);
                msg.AppendFormat("StackTrace {0}\n", error.StackTrace);
                MessageBox.Show(msg.ToString(), "Atención",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbPolvo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPolvo.Checked)
            {
                this.txtCantidadGramosLiquidos.Enabled = true;
            }
            else
            {
                this.txtCantidadGramosLiquidos.Enabled = false;
            }
        }
    }
}
