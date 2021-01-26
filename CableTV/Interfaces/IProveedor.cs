using Quiz2.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Interface
{
    public interface IProveedor
    {
        double CostoBase { get; }
        string Nombre { get; }
        Zona _Zona { get; set; }

        double AplicarDescuentos(Paquete paquete);
        double CostoSegunCantidadTV(int cantidadTV);
        double ObtenerCosto();
    }
}
