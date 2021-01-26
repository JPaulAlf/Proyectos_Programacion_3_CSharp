using Quiz2.CableTV.Clases;
using Quiz2.CableTV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Factory
{
    public class ProveedorFactory
    {
        public IProveedor CrearProveedor(bool TeleCable, bool CableTica, bool TigoStar, Zona zona)
        {
            IProveedor proveedor = null;

            if (TeleCable)
            {
                proveedor = new TeleCable();
                proveedor._Zona = zona;
            }

            if (CableTica)
            {
                proveedor = new CableTica();
                proveedor._Zona = zona;
            }

            if (TigoStar)
            {
                proveedor = new TigoStar();
                proveedor._Zona = zona;
            }

            return proveedor;

        }
    }
}
