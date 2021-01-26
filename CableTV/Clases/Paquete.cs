using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public abstract class Paquete
    {
      public  int CantidadTV { get; set; }
      public abstract string Descripcion { get;  }
      public List<Adicionales> ListaAdicionales { get; set; } = new List<Adicionales>();
      public  abstract float PorcentajeCosto { get; }
      public abstract float PorcentajeImpuesto { get; }

        public void AgregarAdicional(Adicionales adicional)
        {
            ListaAdicionales.Add(adicional);
        }
        
        public double CostoAdicional(Zona zona)
        {
            double costo = 0;

            foreach(Adicionales adicional in ListaAdicionales)
            {
                switch(adicional)
                {
                    case Adicionales.TV: costo += zona.PrecioTV;
                        break;
                    case Adicionales.Telefono: costo += zona.PrecioTelefono;
                        break;
                    case Adicionales.Internet: costo += zona.PrecioInternet;
                        break;
                    case Adicionales.Digital: costo += zona.PrecioDigital;
                        break;
                }
            }
            return costo;
        }

        public bool TieneAdicional(Adicionales adicional)
        {
            if(this.ListaAdicionales.Count() > 0) 
            return true;

            return false;
        }

    }
}
