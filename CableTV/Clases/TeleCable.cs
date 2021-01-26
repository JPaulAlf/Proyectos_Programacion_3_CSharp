using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class TeleCable : IProveedor
    {
        public double CostoBase { get; } = 10000.0d;

        public string Nombre { get; } = "TeleCable";

        public Zona _Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            double descuento = 0;
            if (paquete.ListaAdicionales.Contains(Adicionales.Digital))
            {
                descuento += this.CostoBase* .50;
            }
            if(paquete is Premium)
            {
                descuento += this.CostoSegunCantidadTV(paquete.CantidadTV);
            }
            return descuento;
        }

        public double CostoSegunCantidadTV(int cantidadTV)
        {
            double costo = 0;
            if (cantidadTV >= 1 && cantidadTV <= 3)
                costo= cantidadTV * 500;
            if (cantidadTV >= 4 && cantidadTV <= 5)
                costo = cantidadTV * 450;
            if (cantidadTV >= 6 )
                costo= cantidadTV * 400;

            return costo;
        }

        public double ObtenerCosto()
        {
            return CostoBase + _Zona.PrecioTV;
        }
    }
}
