using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTN.Winform.SnackMachine.Class
{
    class Factura : ICloneable
    {
        public int NumeroFactura { get; }
        public DateTime FechaFactura { get; } = DateTime.Now;
        private DetalleFactura _DetalleFactura = new DetalleFactura();
        public Factura()
        {
            NumeroFactura = new Random(99999).Next(10000);
            _DetalleFactura = new DetalleFactura();
        }
        public void DeleteItemPedido(Snack pSnack)
        {
            _DetalleFactura.DeleteSnack(pSnack);
        }
        public void AddSnack(Snack pSnack)
        {
            _DetalleFactura.AddSnack(pSnack);
        }
        public double GetMontoFactura()
        {
            return _DetalleFactura.GetMontoFactura();
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            /*
            </raiz>
            <factura numerofactura = "123">
            <fechafactura>"01/01/2022"</fechafactura>
           <detalle>
            <snack>
            <tipo>Chocolate</tipo>
           <precio>1000</precio>
           <impuesto>113</impuesto>
           <montototal>1113</montototal>
            <snack>
            <snack>
            <tipo>Chip</tipo>
           <precio>200</precio>
           <impuesto>26</impuesto>
            <montototal>226</montototal>
            <snack>
            </detalle>
            </factura>
            </raiz>
            */
            XmlDocument documento = new XmlDocument();
            XmlDeclaration dec = documento.CreateXmlDeclaration("1.0", null,
           null);
            documento.AppendChild(dec);

            //// XSLT
            XmlProcessingInstruction xslt =
             documento.CreateProcessingInstruction
             ("xml-stylesheet", "type=\"text/xsl\" href=\"factura.xslt\"");
            documento.AppendChild(xslt);

            XmlElement raiz = documento.CreateElement("raiz");
            XmlElement factura = documento.CreateElement("factura");

            factura.SetAttribute("numerofactura", NumeroFactura.ToString());

            XmlElement fechafactura = documento.CreateElement("fechafactura");
            fechafactura.InnerText = FechaFactura.ToString();
            factura.AppendChild(fechafactura);

            XmlElement detalle = documento.CreateElement("detalle");
            foreach (var oSnack in _DetalleFactura.ListaSnacks)
            {
                XmlElement snack = documento.CreateElement("snack");
                XmlElement tipo = documento.CreateElement("tipo");
                tipo.InnerText = oSnack.GetType().Name;
                XmlElement montototal = documento.CreateElement("precio");
                montototal.InnerText = oSnack.MontoTotal().ToString();
                snack.AppendChild(tipo);
                snack.AppendChild(montototal);
                detalle.AppendChild(snack);
            }
            factura.AppendChild(detalle);
            raiz.AppendChild(factura);
            documento.AppendChild(raiz);
            return documento.InnerXml;
        } // fin
    }
}
