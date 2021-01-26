using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class CableTica : IProveedor
    {
        public double CostoBase { get; } = 11000.0d;

        public string Nombre { get; } = "CableTica";

        public Zona _Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            double descuento = 0;
            if (paquete.ListaAdicionales.Contains(Adicionales.Internet))
            {
                descuento += _Zona.PrecioInternet* .45;
            }
            if (paquete is Deportivo)
            {
                descuento += _Zona.PrecioTelefono* 1.00 + _Zona.PrecioInternet*.30;
            }
            return descuento;
        }

        public double CostoSegunCantidadTV(int cantidadTV)
        {
            double costo = 0;
            if (cantidadTV >= 1 && cantidadTV <= 2)
                costo = cantidadTV * 400;
            if (cantidadTV >= 3 && cantidadTV <= 5)
                costo = cantidadTV * 300;
            if (cantidadTV >= 6)
                costo = cantidadTV * 250;

            return costo;
        }

        public double ObtenerCosto()
        {
            return CostoBase + _Zona.PrecioTV;
        }

    }
}
