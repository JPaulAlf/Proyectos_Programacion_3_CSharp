using Quiz2.CableTV.Clases;
using Quiz2.CableTV.Facade;
using Quiz2.CableTV.Factory;
using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Quiz2.CableTV
{
    public partial class frmPrincipal : Form
    {
        private Zona oZona = null;


        public frmPrincipal()
        {
            InitializeComponent();
        }


  
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Favor llenar Nombre");
                    return;
                }
                if (!this.mtxId.MaskFull) { 
                MessageBox.Show("Favor llenar Identificacion");
                    return;
                }
                if (this.lstPaquetes.SelectedIndex==-1)
                {
                    MessageBox.Show("Favor seleccionar un Paquete");
                    return;
                }

                //Variable locales que se usan para crear los objetos cliente y paquete
                string nombre = this.txtNombre.Text;
                string identificacion = this.mtxId.Text;
                DateTime fechaNacimiento= this.dtpFechaNace.Value;
                int cantidadTV = (int)nudCantidadTV.Value;

                // Se instancia el objeto factory para crear el proveedor
                ProveedorFactory proveedorFactory = new ProveedorFactory();
                IProveedor proveedor = proveedorFactory.CrearProveedor(rbtTeleCable.Checked, rbtCableTica.Checked, rbtTigoStar.Checked, oZona);


                // Se instancia zona para poder buscar la zona especifica que selecciono el usuario
                oZona = new Zona();
                foreach (Zona pZona in oZona.ObtenerZonasPorProveedor(proveedor.Nombre))
                {
                    if (pZona.Nombre.Equals((string)cmbZonas.SelectedItem))
                        oZona = pZona;
                }

                // Se refresca la variable oZona, ya que cuando se creó el objeto proveedor, ésta venía nula.
                proveedor._Zona = oZona;

                // Se crea el objeto paquete, dependiendo de lo seleccionado por el usuario
                Paquete paquete = null;
                string paqueteSelected = (string) lstPaquetes.SelectedItem;
                switch(paqueteSelected){
                    case "Paquete Basico": 
                        paquete = new Basico();
                        paquete.CantidadTV = cantidadTV;
                        break;
                    case "Paquete Deportivo": 
                        paquete = new Deportivo();
                        paquete.CantidadTV = cantidadTV;
                        break;
                    case "Paquete Premium": 
                        paquete = new Premium();
                        paquete.CantidadTV = cantidadTV;
                        break;
                }

                // Se gregan los adicionales seleccionados por el usuario
                if(chkDigital.Checked)
                    paquete.AgregarAdicional(Adicionales.Digital);
                if(chkInternet.Checked)
                    paquete.AgregarAdicional(Adicionales.Internet);
                if(chkTelefono.Checked)
                    paquete.AgregarAdicional(Adicionales.Telefono);

                // Se crea el objeto cliente y se la da valor a sus propiedades
                Cliente cliente = new Cliente()
                {
                    FechaNacimiento = fechaNacimiento,
                    Identificacion = identificacion,
                    Nombre = nombre,
                    Paquete = paquete,
                    Proveedor = proveedor
                };

                // Se instancia la clase CotizadorFacade y se llama para cotizar y guardar el archivo xml
                CotizadorFacade cotizador = new CotizadorFacade(cliente);
                double costo = cotizador.CalcularCosto();

                // Guarda el archivo XML
                saveFileDialog1.Filter = "Solo XML | *.xml";
                DialogResult resultado = saveFileDialog1.ShowDialog();
                if (resultado == System.Windows.Forms.DialogResult.OK)
                {
                    // Aquí agarra la ruta entera del archivo
                    string ruta = Path.GetFullPath(saveFileDialog1.FileName);
                    Console.WriteLine("Path: {0}", ruta);

                    cotizador.ExportarXML(ruta);

                    XslCompiledTransform myXslTrans = new XslCompiledTransform();

                    // Carga en memoria la lectura xslt
                    myXslTrans.Load(@"..\\..\\CableTV.xslt");

                    // Transforma el archivo xml aun archivo HTML
                    myXslTrans.Transform(ruta, "CableTV.html");

                    ruta = "CableTV.html";
                    this.webBrowser.Url = new Uri(Application.StartupPath + "\\" + ruta);
                }

                // Imprime en consola el valor de costo
                Console.WriteLine("Costo Total: {0}", costo);

            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

               Console.WriteLine(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region COMBO BOXES LLENADO Y LISTA

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.lstPaquetes.Items.Add("Paquete Basico");
            this.lstPaquetes.Items.Add("Paquete Deportivo");
            this.lstPaquetes.Items.Add("Paquete Premium");

            this.SetCulture();
        }


        private void rbtTeleCable_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbZonas.Items.Clear();

            oZona = new Zona();
            foreach(Zona pZona in oZona.ObtenerZonasPorProveedor("TeleCable"))
            {
                this.cmbZonas.Items.Add(pZona.Nombre);
            }
            this.cmbZonas.SelectedIndex = 0;
        }

        private void rbtCableTica_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbZonas.Items.Clear();

            oZona = new Zona();
            foreach (Zona pZona in oZona.ObtenerZonasPorProveedor("CableTica"))
            {
                this.cmbZonas.Items.Add(pZona.Nombre);
            }
            this.cmbZonas.SelectedIndex = 0;
        }

        private void rbtTigoStar_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbZonas.Items.Clear();

            oZona = new Zona();
            foreach (Zona pZona in oZona.ObtenerZonasPorProveedor("TigoStar"))
            {
                this.cmbZonas.Items.Add(pZona.Nombre);
            }
            this.cmbZonas.SelectedIndex = 0;
        }

        public void SetCulture()
        {
            // Colocar Cultura Estandar para Costa Rica
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            Thread.CurrentThread.CurrentCulture = Micultura;
        }

        #endregion

    }
}
