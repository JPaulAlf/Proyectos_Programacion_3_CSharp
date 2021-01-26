using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Class;

namespace UTN.Winform.Examen1.LogiCargo.Interface
{
    interface IPaquete
    {
       void AgregarProducto(Producto pProducto);
        void AsignarAgenciaAduana(IAgenciaAduanal pAgenciaAduanal);
        void AsignarCliente(ICliente pCliente);
        double CantidadBitcoins();
        double MontoTotal();
        string ObtenerXML();
    }
}
