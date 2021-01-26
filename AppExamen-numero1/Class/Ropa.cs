using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Class
{
    class Ropa : Producto, IImpuesto
    {
        public override double Costo()
        {
            return Precio +  Impuesto();
        }

        public double Impuesto()
        {
            return Precio * 0.13;
        }
    }
}
