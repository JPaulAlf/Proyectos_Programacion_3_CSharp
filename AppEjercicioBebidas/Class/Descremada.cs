using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Descremada, hereda de la clase Leche sus metodos y propiedades
    /// </summary>
    class Descremada : Leche
    {
        /// <summary>
        ///Metodo que sobre-escribe metodo heredado de Leche,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Cantidad de calorias</returns>
        public override int Calorias()
        {
            return 150;
        }

        /// <summary>
        /// Metodo que sobre-escribe metodo heredado de Leche,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Costo del la leche</returns>
        public override double Costo()
        {
            return 500;
        }
    }
}
