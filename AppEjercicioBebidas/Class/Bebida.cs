using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Bebida, contiene todos los calculos relacionados y creacion del XML
    /// </summary>
       public class Bebida
    {


        /// <summary>
        /// Lista de ingredientes de la bebida
        /// </summary>
        private List<Ingrediente> listaIngredientes = new List<Ingrediente>();
        /// <summary>
        /// Almacena el tipo de liquido de la Bebida
        /// </summary>
        private Liquido oLiquido = null;


        /// <summary>
        /// Metodo que agrega el ingrediente, a la lista de bebidas  
        /// </summary>
        /// <param name="pIngrediente">Ingrediente a agregar</param>
        /// <returns>No retorna</returns>
        public void AgregarIngrediente(Ingrediente pIngrediente)
        {
            this.listaIngredientes.Add(pIngrediente);
        }



        /// <summary>
        /// Metodo que asigna el tipo de liquido a la variable oLiquido
        /// </summary>
        /// <param name="pLiquido">Tipo de liquido</param>
        /// <returns>No retorna</returns>
        public void AsiganarLiquido(Liquido pLiquido)
        {
            this.oLiquido = pLiquido;
        }



        /// <summary>
        /// Metodo que recorre la lista de ingredientes y hace un sumatoria
        /// de los costos totales mas el impuesto de los ingredientes agregados y de la bebida
        /// </summary>
        /// <returns>Costo de la bebida con impuestos incluidos</returns>    
        public double Costo()
        {
            double monto = 0;
            foreach(Ingrediente ingrediente in listaIngredientes)
            {
                monto += ingrediente.Costo();
            }
            return monto + oLiquido.Costo() + Impuesto();
        }



        /// <summary>
        /// Metodo que recorre la lista de ingredientes y hace un sumatoria
        /// de las calorias totales  de los ingredientes agregados y de la bebida
        /// </summary>
        /// <returns>Cantidad de calorias de los ingredientes y la bebida</returns>   
        public int Caloria()
        {
            int cantidad = 0;
            foreach (Ingrediente ingrediente in listaIngredientes)
            {
                cantidad += ingrediente.Calorias();
            }
            return cantidad + oLiquido.Calorias();
        }


        /// <summary>
        /// Metodo que recorre la lista de ingredientes y hace un sumatoria
        /// de los costos totales  de los ingredientes agregados y de la bebida y
        /// los multiplica por el .13% que corresponde al IVA
        /// </summary>
        /// <returns>Costo del impuesto de la bebida</returns>   
        public double Impuesto()
        {
            double monto = 0;
            foreach (Ingrediente ingrediente in listaIngredientes)
            {
                monto += ingrediente.Costo();
            }
            return (monto + oLiquido.Costo()) * .13;
        }


        /// <summary>
        /// Metodo que retorna la lista de ingredientes de la bebida
        /// </summary>
        /// <returns>Lista de ingredientes</returns>   
        private List<Ingrediente> ObtenerIngredientes()
        {
            return listaIngredientes;
        }


        /// <summary>
        /// Metodo que retorna el liquido de la bebida
        /// </summary>
        /// <returns>Lista de ingredientes</returns> 
        private Liquido ObtenerLiquido()
        {
            return oLiquido;
        }


        /// <summary>
        /// Metodo que construye el XML con la informacion de la bebida, y
        /// lo retorna para su posterior uso
        /// </summary>
        /// <returns>XML creado</returns>
        public override string ToString()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec); // Se crea la raiz

            XmlProcessingInstruction xslt = 
       doc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"facturabebida.xsl\"");
            doc.AppendChild(xslt);

            XmlElement root = doc.CreateElement("factura");
            doc.AppendChild(root);
            XmlElement encabezado = doc.CreateElement("encabezado");
            encabezado.SetAttribute("fecha", DateTime.Now.ToString("dd/MM/yyyy hh: mm:ss"));
           
            XmlElement calorias = doc.CreateElement("calorias");
            calorias.InnerText = Caloria().ToString();
            encabezado.AppendChild(calorias);
            XmlElement costo = doc.CreateElement("costo");
            costo.SetAttribute("impuesto", Impuesto().ToString("#,###,###.00"));
            costo.InnerText = Costo().ToString("#,###,###.00");
            encabezado.AppendChild(costo);

            // recorrer los ingredientes y crear un elemento
            foreach (Ingrediente oIngrediente in ObtenerIngredientes())
            {
                XmlElement ingredientes = doc.CreateElement("ingredientes");
                XmlElement ingrediente = doc.CreateElement("ingrediente");
                ingrediente.InnerText = "Nombre: "+oIngrediente.ToString() + "....................Costo de ingrediente: " + oIngrediente.Costo();
                // Se agrega a ingredientes !
                ingredientes.AppendChild(ingrediente);
                root.AppendChild(ingredientes);
            }
            // Agregar liquido..
            XmlElement m_ingredientes = doc.CreateElement("ingredientes");
            XmlElement m_ingrediente = doc.CreateElement("ingrediente");
            m_ingrediente.InnerText = "Nombre: " + oLiquido.ToString() + "....................Costo de ingrediente: " + oLiquido.Costo();
            // Se agrega a ingredientes !
            m_ingredientes.AppendChild(m_ingrediente);
            root.AppendChild(m_ingredientes);
            root.AppendChild(m_ingredientes);

            //root.AppendChild(ingredientes);
            root.AppendChild(encabezado);
            return doc.OuterXml;
        }


        //public override string ToString()
        //{
        //    StringBuilder hilera = new StringBuilder();
        //    hilera.Append("Liquido: ").Append(oLiquido.ToString()).Append("\n");
        //    hilera.Append("Ingredientes: \n");
        //    foreach (Ingrediente ingrediente in listaIngredientes)
        //    {
        //        hilera.Append(ingrediente.ToString()).Append("\n");
        //    }
        //    hilera.Append("Calorias: ").Append(Caloria()).Append("\n");
        //    hilera.Append("Impuesto: ").Append(Impuesto()).Append("\n");
        //    hilera.Append("Costo: ").Append(Costo()).Append("\n");
        //    return hilera.ToString();
        //}


    }
}
