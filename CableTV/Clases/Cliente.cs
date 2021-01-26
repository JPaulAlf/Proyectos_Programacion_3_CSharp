using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class Cliente
    {
        public DateTime FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public Paquete Paquete { get; set; }
        public IProveedor Proveedor { get; set; }


    }
}
