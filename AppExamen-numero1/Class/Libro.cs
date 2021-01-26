using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Class
{
    class Libro : Producto, IIncentivo, ICostoTamanno
    {
        public double CantidadBitcoins()
        {
            return Precio * 0.15;
        }

        public override double Costo()
        {
            return Precio + CostoTamanno() - Descuento();
        }

        public double CostoTamanno()
        {
            return (TamannoAlto * 1) + (TamannoAncho * 2) + (TamannoLargo * 2);
        }

        public double Descuento()
        {
            return Precio * .05;
        }
    }
}
