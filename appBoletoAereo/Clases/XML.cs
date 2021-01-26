using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Boleto.Clases
{
    class XML
    {
        public static void CrearArchivoXML(string miXML)
        {
            string rutaDocumento = "E:\\CARPETAS_IMPORTANTES\\Documents\\UNIVERSIDAD\\UTN DOC 5CT\\Programacion 3\\SEMANA 3\\Practica\\EjercicioBoleto\\appBoletoAereo\\Clases\\MiXML.xml";
            string documentoXML = miXML;

            if (!File.Exists(rutaDocumento))
            {
                using (StreamWriter file = new StreamWriter(rutaDocumento, true))
                {
                    file.WriteLine(documentoXML);
                    file.Close();
                }
            }
            else
            {
                File.Delete(rutaDocumento);
                using (StreamWriter file = new StreamWriter(rutaDocumento, true))
                {
                    file.WriteLine(documentoXML);
                    file.Close();
                }
            }
        }
        public static void CrearArchivoXML2(string miXML)
        {
            string ruta = @"c:\tem\";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            File.WriteAllText(ruta + "boleto.xml", miXML);
        }
    }
}
            
    
