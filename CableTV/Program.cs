using Quiz2.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Quiz2.CableTV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //String datos = File.ReadAllText("../../Json/Zonas.json");
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //List<Zona> lista = jss.Deserialize<List<Zona>>(datos);

            //foreach(Zona zona in lista)
            //{
            //    Console.WriteLine(zona.Nombre);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());


      
    }
    }
}
