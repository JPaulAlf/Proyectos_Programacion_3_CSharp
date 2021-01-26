using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Class;
using UTN.Winform.Examen1.LogiCargo.Interface;

namespace UTN.Winform.Examen1.LogiCargo.Gestores
{
    class Gestor
    {
        private IPaquete _Paquete;

        public Gestor()
        {
            _Paquete = new Paquete();
        }

        public void AgregarProducto(Producto pProducto)
        {
            _Paquete.AgregarProducto(pProducto);
        }

        internal void AsignarAgenciaAduana(IAgenciaAduanal pAgenciaAduanal)
        {
            _Paquete.AsignarAgenciaAduana(pAgenciaAduanal);
        }

        public void AsignarCliente(ICliente pCliente)
        {
            _Paquete.AsignarCliente(pCliente);
        }

        public double CantidadBitcoins()
        {
            return _Paquete.CantidadBitcoins();
        }

        public double MontoTotal()
        {
            return _Paquete.MontoTotal();
        }

        public string ObtenerXML()
        {
            return _Paquete.ObtenerXML();
        }
    }
}
