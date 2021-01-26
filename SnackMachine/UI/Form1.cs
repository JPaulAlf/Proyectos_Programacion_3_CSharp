using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.SnackMachine.Class;
using UTN.Winform.SnackMachine.Factories;
using UTN.Winform.SnackMachines.Util;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;

namespace form
{
    public partial class Form1 : Form
    {
        private SnackMachine _SnackMachine = new SnackMachine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = this.Text + " " +
               Application.ProductVersion + " " + Application.ProductName;
                Utilitarios.CulturaInfo();
                CargarSnackMachine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Atención");
            }
        }

        private void btnProducto1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarSolicitud(TipoSnack.Chocolate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Atención");
            }
        }

        private void btnProducto2_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarSolicitud(TipoSnack.Candy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Atención");
            }
        }

        private void btnProducto3_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarSolicitud(TipoSnack.Chip);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Atención");
            }
        }

        private void btnProducto4_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarSolicitud(TipoSnack.Drink);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Atención");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double monto = 0d;
            Factura oFactura = null;
            try
            {
                if (string.IsNullOrEmpty(mskPagoRealizado.Text))
                {
                    MessageBox.Show("Ingrese el monto con el que cancela",
                   "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                monto = double.Parse(mskPagoRealizado.Text);
                oFactura = _SnackMachine.PayBill(monto);
                LimpiarUI();

                //Utilitarios.PlaySound(@"..\..\Media\machine.wav");
                Utilitarios.Hablar("Gracias por su compra");
                // MessageBox.Show("Tome su producto !", "Atención",
                // MessageBoxButtons.OK, MessageBoxIcon.Information);



                // Extraer el XML
                string xml = oFactura.ToString();
                // Preguntar si el directorio existe?, sino lo crea
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");
                // Salvar los datos de texto en la ruta del archivo factura.xml
                File.WriteAllText(@"c:\temp\factura.xml", xml);
                // Copia el XSLT en c:\temp
                File.Copy(@"..\..\XSLT\factura.xslt",@"c:\temp\factura.xslt",true);
                // invoca el explorador


                Process.Start("iexplore.exe", @"C:\temp\factura.xml");
                //Process.Start(@"C:\temp\factura.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Atención");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            try
            {
                LimpiarUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Atención");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void LimpiarUI()
        {
            lstSnacksSeleccionados.Items.Clear();
            this.txtMontoXPagar.Clear();
            mskPagoRealizado.Clear();
        }
        private void ProcesarSolicitud(TipoSnack pTipoSnack)
        {
            Snack oSnack = null;
            bool respuesta = false;
            oSnack = FactorySnack.CreateSnack(pTipoSnack);
            respuesta = _SnackMachine.GetSnack(oSnack);
            if (respuesta)
                lstSnacksSeleccionados.Items.Add(oSnack);
            this.txtMontoXPagar.Text = _SnackMachine.GetMontoFactura().ToString();
        }
        private void CargarSnackMachine()
        {
            Snack oChocolate = null;
            Snack oChip = null;
            Snack oDrink = null;
            Snack oCandy = null;
            // Cargar la maquina con productos
            oCandy = FactorySnack.CreateSnack(TipoSnack.Candy);
            oChip = FactorySnack.CreateSnack(TipoSnack.Chip);
            oChocolate = FactorySnack.CreateSnack(TipoSnack.Chocolate);
            oDrink = FactorySnack.CreateSnack(TipoSnack.Drink);
            for (int i = 0; i < 4; i++)
            {
                _SnackMachine.AddSnack(oCandy);
                _SnackMachine.AddSnack(oChip);
                _SnackMachine.AddSnack(oChocolate);
                _SnackMachine.AddSnack(oDrink);
            }
            //Cargar dinero para vuelto
            _SnackMachine.AddMoney(10000);
        }

       

    }
    }
