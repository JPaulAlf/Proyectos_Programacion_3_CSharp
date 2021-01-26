﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Papaya, hereda de la clase Ingrediente sus metodos y propiedades
    /// </summary>
    class Papaya : Ingrediente
    {

        /// <summary>
        ///Metodo que sobre-escribe metodo heredado de Ingrediente,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Cantidad de calorias</returns>
        public override int Calorias()
        {
            return 4*Gramo;
        }


        /// <summary>
        /// Metodo que sobre-escribe metodo heredado de Ingrediente,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Costo del Ingrediente</returns>
        public override double Costo()
        {
            return 35 * Gramo;
        }
    }
}
