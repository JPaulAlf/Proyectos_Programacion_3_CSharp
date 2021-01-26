using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Class
{
    class Paquete : IPaquete
    {

        private IAgenciaAduanal _AgenciaAduanal;
        private ICliente Cliente;
        private List<Producto> ListaProducto;

        public Paquete()
        {
            ListaProducto = new List<Producto>();
        }

        public void AgregarProducto(Producto pProducto)
        {
            ListaProducto.Add(pProducto);
        }

        public void AsignarAgenciaAduana(IAgenciaAduanal pAgenciaAduanal)
        {
            this._AgenciaAduanal = pAgenciaAduanal;
        }

        public void AsignarCliente(ICliente pCliente)
        {
            this.Cliente = pCliente;
        }

        public double CantidadBitcoins()
        {

            double montoTotal = 0.0;
            foreach (Producto producto in ListaProducto)
            {
               if(producto is Libro)
                {
                    montoTotal += (producto as Libro).CantidadBitcoins();
                }

            }
            return montoTotal;
        }

        public double MontoTotal()
        {
            double montoTotal = 0.0;
            foreach(Producto producto in ListaProducto)
            {
                montoTotal += producto.Costo();
            }
            return montoTotal;
        }

        public string ObtenerXML()
        {
            XmlDocument documento = new XmlDocument();
            XmlDeclaration dec = documento.CreateXmlDeclaration("1.0", null, null);
            documento.AppendChild(dec);

            // XSLT - ASIGNA EL ESTILO AL XML 
            XmlProcessingInstruction xslt =
             documento.CreateProcessingInstruction
             ("xml-stylesheet", "type=\"text/xsl\" href=\"examenEnvios.xslt\"");
            documento.AppendChild(xslt);

            XmlElement raiz = documento.CreateElement("raiz");

            XmlElement agenciaaduanal = documento.CreateElement("agenciaaduanal");
            agenciaaduanal.InnerText = _AgenciaAduanal.Nombre;
            raiz.AppendChild(agenciaaduanal);

            XmlElement cliente = documento.CreateElement("cliente");
            cliente.InnerText = Cliente.Nombre;
            raiz.AppendChild(cliente);

            XmlElement items = documento.CreateElement("items");

            foreach (Producto pProducto in ListaProducto)
            {
                XmlElement item = documento.CreateElement("item");

                XmlElement descripcion = documento.CreateElement("descripcion");
                descripcion.InnerText = pProducto.Descripcion;
                item.AppendChild(descripcion);

                XmlElement tipo = documento.CreateElement("tipo");
                tipo.InnerText = pProducto.GetType().Name; 
                item.AppendChild(tipo);

                XmlElement costo = documento.CreateElement("costo");
                costo.InnerText = pProducto.Costo().ToString("##,###.00");
                item.AppendChild(costo);

                items.AppendChild(item);
            }

            XmlElement montoTotal = documento.CreateElement("MontoTotal");
            montoTotal.InnerText = this.MontoTotal().ToString("##,###.00");
            items.AppendChild(montoTotal);

            raiz.AppendChild(items);
            documento.AppendChild(raiz);

            return documento.InnerXml;
        }
    }
}
