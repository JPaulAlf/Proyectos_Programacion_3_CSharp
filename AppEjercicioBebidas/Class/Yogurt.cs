using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Yogurt, hereda de la clase Liquido sus metodos
    /// </summary>
    class Yogurt : Liquido
    {

        /// <summary>
        ///Metodo que sobre-escribe metodo heredado de Liquido,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Cantidad de calorias</returns>
        public override int Calorias()
        {
            return 500;
        }

        /// <summary>
        /// Metodo que sobre-escribe metodo heredado de Liquido,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Costo del Ingrediente</returns>
        public override double Costo()
        {
            return 1000;
        }
    }
}
