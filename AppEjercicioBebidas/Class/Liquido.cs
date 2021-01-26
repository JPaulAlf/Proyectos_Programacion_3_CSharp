using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Bebidas
{
    /// <summary>
    /// Clase Liquido, es abstracta para hacer obligatorio la 
    /// implementacion de los metodos dentro de esta clase, en clases hijas posteriores
    /// </summary>
    abstract class Liquido
    {
        /// <summary>
        /// Descripcion
        /// </summary>
        /// <value>
        /// descripcion del Liquido
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Metodo abstracto, se sobreescribe en clases hijas con valor destinto, segun la
        /// clase que lo implemente
        /// </summary>
        /// <returns>Calorias</returns>
        public abstract int Calorias();

        /// <summary>
        /// Metodo abstracto, se sobreescribe en clases hijas con valor destinto, segun la
        /// clase que lo implemente
        /// </summary>
        /// <returns>Costo</returns>
        public abstract double Costo();

        /// <summary>
        /// Metodo que sobre-escribe el ToString() original, 
        /// por Descripcion
        /// </summary>
        /// <returns>ToString()</returns>
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
