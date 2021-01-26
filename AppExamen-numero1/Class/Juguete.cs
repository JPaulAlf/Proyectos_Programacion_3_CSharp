using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Class
{
    class Juguete : Producto, ICostoPeso, IImpuesto, IDescuento
    {

        public double Descuento()
        {
            return Precio * 0.10;
        }


        public override double Costo()
        {
            return (Precio + CostoPeso())  + Impuesto() - Descuento();
        }

        public double CostoPeso()
        {
            return Peso * 1.5;
        }


        public double Impuesto()
        {
            return Precio * .13;
        }
    }
}
