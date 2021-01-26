 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Sutel.CapaLogica
{
    abstract class Llamada
    {
        public int Duracion { get; set; }

        public abstract double Costo();
        public  double Impuesto(double pMonto)
        {
            return pMonto * .13;
        }
    }
}
