using Quiz2.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Quiz2.CableTV.Facade
{
    public class CotizadorFacade
    {
        private Cliente Cliente;

        public CotizadorFacade(Cliente cliente)
        {
            this.Cliente = cliente;
        }
        public double CalcularCosto()
        {
            #region variables
            double costo = 0;
            double impuesto = 0;
            double porcentajeCosto = 0;
            double descuento = 0;
            double precioSegunTV = 0;
            var proveedor = Cliente.Proveedor;
            var paquete = Cliente.Paquete;
            #endregion variables

            // Sumar el costo del proveedor.
            costo += proveedor.ObtenerCosto();

            // Sumar costos por zona y adicionales
            costo += paquete.CostoAdicional(proveedor._Zona);

            //Sumar el costo por televisores extra
            precioSegunTV = proveedor.CostoSegunCantidadTV(paquete.CantidadTV);
            costo += precioSegunTV;

            // Sacar el porcentaje de impuesto y costo
            impuesto = costo * paquete.PorcentajeImpuesto;
            porcentajeCosto = costo * paquete.PorcentajeCosto;

            // Suma del porcentaje de costo e impuesto
            costo = costo + impuesto + porcentajeCosto;

            // Restar los descuentos
            descuento = proveedor.AplicarDescuentos(paquete);
            costo -= descuento;

            // Retorna el costo total de la cotización
            return costo;
        }

        public void ExportarXML(string ruta)
        {
            XmlDocument documento = new XmlDocument();
            documento.LoadXml("<CableTV></CableTV>");

            XmlElement proveedor1 = documento.CreateElement("Proveedor");
            proveedor1.SetAttribute("Nombre", Cliente.Proveedor.Nombre);

            XmlElement paquete = documento.CreateElement("Paquete");
            paquete.SetAttribute("Descripcion", Cliente.Paquete.Descripcion);
            proveedor1.AppendChild(paquete);

            XmlElement cliente = documento.CreateElement("Cliente");
            cliente.SetAttribute("Identificacion", Cliente.Identificacion);
            cliente.SetAttribute("Nombre", Cliente.Nombre);
            cliente.SetAttribute("FechaNacimiento", Cliente.FechaNacimiento.ToString());
            cliente.SetAttribute("CantidadTV", Cliente.Paquete.CantidadTV.ToString());
            proveedor1.AppendChild(cliente); // Tenía paquete

            XmlElement zona = documento.CreateElement("Zona");
            zona.SetAttribute("PrecioTV", Cliente.Proveedor._Zona.PrecioTV.ToString());
            zona.InnerText = Cliente.Proveedor._Zona.Nombre;
            proveedor1.AppendChild(zona);

            XmlElement adicionales = documento.CreateElement("Adicionales");
            foreach (Adicionales pAdicionales in Cliente.Paquete.ListaAdicionales)
            {
                XmlElement elem = documento.CreateElement("Adicional");
                elem.InnerText = pAdicionales.ToString();
                adicionales.AppendChild(elem);
            }
            proveedor1.AppendChild(adicionales);

            XmlElement total = documento.CreateElement("Total");
            total.SetAttribute("Descuentos", Cliente.Proveedor.AplicarDescuentos(Cliente.Paquete).ToString("#,###,###.00"));
            Console.WriteLine(Cliente.Proveedor.AplicarDescuentos(Cliente.Paquete).ToString("#,###,###.00"));
            total.InnerText = CalcularCosto().ToString("#,###,###.00");

            proveedor1.AppendChild(total);

            documento.DocumentElement.AppendChild(proveedor1);

            documento.Save(ruta);

        }
    }
}
