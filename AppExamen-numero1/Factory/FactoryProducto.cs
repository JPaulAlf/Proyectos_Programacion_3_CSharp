using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Examen1.LogiCargo.Class;

namespace UTN.Winform.Examen1.LogiCargo.Factory
{
    class FactoryProducto
    {
        public  Producto CrearProducto(TipoProducto pTipoProducto)
        {
            Producto oProducto = null;
            switch (pTipoProducto)
            {
                case TipoProducto.Juguete:
                    oProducto = new Juguete();
                    break;
                case TipoProducto.Electronico:
                    oProducto = new Electronico();
                    break;
                case TipoProducto.Libro:
                    oProducto = new Libro();
                    break;
                case TipoProducto.Ropa:
                    oProducto = new Ropa();
                    break;
            }
            return oProducto;
        }




    }
}
