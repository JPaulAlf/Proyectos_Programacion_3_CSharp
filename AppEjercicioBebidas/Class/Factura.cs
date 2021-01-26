using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Factura, guarda en directorio el XML creado
    /// </summary>
    class Factura
    {

        /// <summary>
        /// Metodo que guarda el XML, en un directorio llamado "temp"
        /// </summary>
        /// <param name="pXML">XML generado en la clase bebida</param>
        /// <returns>No retorna valor</returns>
        public void Salvar(string pXML)
        {
            if (!Directory.Exists(@"c:\temp"))
                Directory.CreateDirectory(@"c:\temp");
            File.WriteAllText(@"c:\temp\facturabebida.xml", pXML);

            File.Copy(@"..\..\XSLT\facturabebida.xsl", @"c:\temp\facturabebida.xsl", true); 
        }
    }
}
