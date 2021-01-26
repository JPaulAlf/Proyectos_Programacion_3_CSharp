using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas.Interface
{
    /// <summary>
    /// Interfaz IGramo, contiene metodos y propiedades sin implementar
    /// </summary>
    interface IGramo
    {
        /// <summary>
        /// Gramo
        /// </summary>
        /// <value>
        /// valor del gramo
        /// </value>
        int Gramo { get; set; }

        /// <summary>
        /// Metodo que guarda el valor del gramo recibido en la 
        /// propiedad Gramo
        /// </summary>
        /// <param name="pGramo">valor de gramo</param>
        /// <returns>No retorna valor</returns>
        void AsignarGramo(int pGramo);
    }
}
