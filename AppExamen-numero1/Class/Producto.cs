using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Class
{
    public abstract class Producto
    {
        public string Descripcion { get; set; }
        public double Peso { get; set; }
        public double Precio { get; set; }
        public double  TamannoAlto { get; set; }
        public double  TamannoAncho { get; set; }
        public double TamannoLargo { get; set; }

        public abstract double Costo();
    }
}
