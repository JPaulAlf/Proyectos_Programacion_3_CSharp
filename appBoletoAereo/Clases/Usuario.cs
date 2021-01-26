using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTN.WinForms.Boleto.Clases
{
    public class Usuario
    {
        #region Propiedades de la clase
        public Boleto _Boleto { get; set; }
        public string Genero { get; set; }
        public string Id { get; set; }
        public  Pais Nacionalidad { get; set; }
        public string Nombre { get; set; }
        #endregion

        public void asignaBoleto(Boleto boletop)
        {
            this._Boleto = boletop;
        }

        public override string ToString()
        {
            XmlDocument documento = new XmlDocument();
            XmlDeclaration delcaracion =
                documento.CreateXmlDeclaration("1.0", "iso-8859-1", null);

            documento.AppendChild(delcaracion);

            XmlElement raiz = documento.CreateElement("raiz");
            documento.AppendChild(raiz);

            XmlElement identificacion = documento.CreateElement("identificacion");
            identificacion.InnerText = Id;
            raiz.AppendChild(identificacion);

            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = Nombre;
            raiz.AppendChild(nombre);

            XmlElement nacionalidad = documento.CreateElement("nacionalidad");
            nacionalidad.InnerText = Nacionalidad.Nombre;
            raiz.AppendChild(nacionalidad);

            XmlElement costos = documento.CreateElement("costos");
            costos.InnerText = this._Boleto.Total().ToString();
            costos.SetAttribute("Monto", this._Boleto.Monto().ToString());
            costos.SetAttribute("Tax",this._Boleto.Tax().ToString());
            raiz.AppendChild(costos);

            return documento.OuterXml.ToString();
        }
    }
}
