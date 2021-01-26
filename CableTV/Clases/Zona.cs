using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Quiz2.CableTV.Clases
{
    [DataContract()]
    public class Zona
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public double PrecioDigital { get; set; }
        [DataMember]
        public double PrecioInternet { get; set; }
        [DataMember]
        public double PrecioTelefono { get; set; }
        [DataMember]
        public double PrecioTV { get; set; }
        [DataMember]
        public string Proveedor { get; set; }

        private List<Zona> ObtenerZonas()
        {
            String datos = File.ReadAllText("../../Zonas.json");
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<Zona> lista = jss.Deserialize<List<Zona>>(datos);

            return lista;
        }

        public List<Zona> ObtenerZonasPorProveedor(string proveedor)
        {
            List<Zona> listaFiltrada = new List<Zona>();
            foreach(Zona pZona in ObtenerZonas())
            {
                if (pZona.Proveedor.Equals(proveedor))
                {
                    listaFiltrada.Add(pZona);
                }
               
            }
            return listaFiltrada;
        }
    }
}
