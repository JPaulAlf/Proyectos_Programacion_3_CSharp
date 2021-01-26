using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Agua, hereda de Liquido sus metodos y propiedades
    /// </summary>
    class Agua : Liquido
    {
        /// <summary>
        ///Metodo que sobre-escribe metodo heredado de Liquido,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Cantidad de calorias</returns>
        public override int Calorias()
        {
            return 0;
        }
        /// <summary>
        /// Metodo que sobre-escribe metodo heredado de Liquido,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Costo de la agua</returns>
        public override double Costo()
        {
            return 200;
        }

    }
}
