using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class TigoStar : IProveedor
    {
        public double CostoBase { get; } = 12000.0d;

        public string Nombre { get; } = "TigoStar";

        public Zona _Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            double descuento = 0;
            if (paquete.ListaAdicionales.Contains(Adicionales.Digital))
            {
                descuento += this.CostoBase * .55;
            }
            if (paquete is Premium)
            {
                descuento += _Zona.PrecioDigital * .75 + _Zona.PrecioInternet*.25;
            }
            return descuento;
        }

        public double CostoSegunCantidadTV(int cantidadTV)
        {
            double costo = 0;
            if (cantidadTV >= 1 && cantidadTV <= 4)
                costo = cantidadTV* 450;
            if (cantidadTV >= 5 && cantidadTV <= 6)
                costo = cantidadTV * 375;
            if (cantidadTV >= 7)
                costo = cantidadTV * 325;

            return costo;
        }

        public double ObtenerCosto()
        {
            return CostoBase + _Zona.PrecioTV;
        }
    }
}
