using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Bebidas.Interface;

namespace UTN.Winform.Bebidas.Class
{
    /// <summary>
    /// Clase Polvo, hereda de la clase Leche y de 
    /// la interfaz IGramo sus metodos y propiedades
    /// </summary>
    class Polvo : Leche, IGramo
    {
        /// <summary>
        /// Gramo
        /// </summary>
        /// <value>
        /// valor del gramo
        /// </value>
        public int Gramo { get; set; }

        /// <summary>
        /// Metodo que guarda el valor del gramo recibido en la 
        /// propiedad Gramo
        /// </summary>
        /// <param name="pGramo">valor de gramo</param>
        /// <returns>No retorna valor</returns>
        public void AsignarGramo(int pGramo)
        {
            Gramo = pGramo;
        }

        /// <summary>
        ///Metodo que sobre-escribe metodo heredado de Leche,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Cantidad de calorias</returns>
        public override int Calorias()
        {
            return 50 * Gramo;
        }


        /// <summary>
        /// Metodo que sobre-escribe metodo heredado de Leche,
        /// y asigna nuevo valor de retorno segun la clase
        /// </summary>
        /// <returns>Costo del Ingrediente</returns>
        public override double Costo()
        {
            return 100 * Gramo;
        }
    }
}
