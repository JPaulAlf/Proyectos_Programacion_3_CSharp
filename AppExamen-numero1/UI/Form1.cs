using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Examen1.LogiCargo.Class;
using UTN.Winform.Examen1.LogiCargo.Factory;
using UTN.Winform.Examen1.LogiCargo.Gestores;
using UTN.Winform.Examen1.LogiCargo.JSON;
using UTN.Winform.Examen1.LogiCargo.Util;

namespace appExamen_JohnPaul_Alfaro
{
    public partial class Form1 : Form
    {

        Gestor oGestor = new Gestor();

        public Form1()
        {
            InitializeComponent();
        }


        //listo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.LlenaDGV_Con_JSON();
                this.wbBuscador.Url = null;
                this.dgvPequenno.Rows.Clear();
                //this.dgvPequenno.Columns.Clear();



            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //listo
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                String datos = File.ReadAllText(@"c:\temp\Datos.json");
                DatosJSON _DatosJSON = JSONGenericObject<DatosJSON>.JSonToObject(datos);

                Cliente _cliente = new Cliente();
                _cliente.Nombre = _DatosJSON.Cliente;
                AgenciaAduanal _Agencia = new AgenciaAduanal();
                _Agencia.Nombre = _DatosJSON.NombreAgenciaAduanal;

                oGestor.AsignarAgenciaAduana(_Agencia);
                oGestor.AsignarCliente(_cliente);

                Producto oProducto = null;
                FactoryProducto _Factory = new FactoryProducto();

                foreach(ListaJson oLista in _DatosJSON.Lista)
                {

                if (oLista.TipoProducto.Equals("Electronico", StringComparison.InvariantCultureIgnoreCase))
                    {
                        oProducto = _Factory.CrearProducto(TipoProducto.Electronico);
                        oProducto.Descripcion = oLista.Descripcion;
                        oProducto.Peso = oLista.Peso;
                        oProducto.Precio = oLista.Precio;
                        oProducto.TamannoAlto = oLista.TamanoAlto;
                        oProducto.TamannoAncho = oLista.TamanoAncho;
                        oProducto.TamannoLargo = oLista.TamanoLargo;

                    }
                if (oLista.TipoProducto.Equals("Ropa", StringComparison.InvariantCultureIgnoreCase))
                    {
                        oProducto = _Factory.CrearProducto(TipoProducto.Ropa);
                        oProducto.Descripcion = oLista.Descripcion;
                        oProducto.Peso = oLista.Peso;
                        oProducto.Precio = oLista.Precio;
                        oProducto.TamannoAlto = oLista.TamanoAlto;
                        oProducto.TamannoAncho = oLista.TamanoAncho;
                        oProducto.TamannoLargo = oLista.TamanoLargo;
                    }
                if (oLista.TipoProducto.Equals("Libro", StringComparison.InvariantCultureIgnoreCase))
                    {
                        oProducto = _Factory.CrearProducto(TipoProducto.Libro);
                        oProducto.Descripcion = oLista.Descripcion;
                        oProducto.Peso = oLista.Peso;
                        oProducto.Precio = oLista.Precio;
                        oProducto.TamannoAlto = oLista.TamanoAlto;
                        oProducto.TamannoAncho = oLista.TamanoAncho;
                        oProducto.TamannoLargo = oLista.TamanoLargo;
                    }
                if (oLista.TipoProducto.Equals("Juguete", StringComparison.InvariantCultureIgnoreCase))
                    {
                        oProducto = _Factory.CrearProducto(TipoProducto.Juguete);
                        oProducto.Descripcion = oLista.Descripcion;
                        oProducto.Peso = oLista.Peso;
                        oProducto.Precio = oLista.Precio;
                        oProducto.TamannoAlto = oLista.TamanoAlto;
                        oProducto.TamannoAncho = oLista.TamanoAncho;
                        oProducto.TamannoLargo = oLista.TamanoLargo;
                    }


                    oGestor.AgregarProducto(oProducto);
                }

                double MontoTotal = oGestor.MontoTotal();
                double BitCoins = oGestor.CantidadBitcoins();

                dgvPequenno.Rows.Add(MontoTotal, BitCoins);

                String XML = oGestor.ObtenerXML();

                File.Copy(@"..\..\XSLT\examenEnvios.xslt", @"c:\temp\examenEnvios.xslt", true);
                File.WriteAllText(@"c:\temp\examenEnvios.xml", XML);

                this.wbBuscador.Navigate(@"c:\temp\examenEnvios.xml");


            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //listo
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                this.Text = fvi.ProductName;

                this.lblfechaHora.Text = DateTime.Now.ToString();

                this.SetCulture();

                this.LlenaDGV_Con_JSON();




            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //listo
        public void LlenaDGV_Con_JSON()
        {
            try
            {

                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                File.Copy(@"..\..\JSON\Datos.json", @"c:\temp\Datos.json", true);

                String datos = File.ReadAllText(@"c:\temp\Datos.json");

                DatosJSON _DatosJSON = JSONGenericObject<DatosJSON>.JSonToObject(datos);

                this.dgvGrande.DataSource = _DatosJSON.Lista;




            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //listo
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

        //listo
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {

                Application.Exit();


            }
            catch (Exception err)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", err.Message);
                msg.AppendFormat("Source         {0}\n", err.Source);
                msg.AppendFormat("Data           {0}\n", err.Data);
                msg.AppendFormat("InnerException {0}\n", err.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
