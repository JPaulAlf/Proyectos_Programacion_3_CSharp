using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Bebidas.Class;

namespace UTN.Winform.Bebidas.Gestor
{
    /// <summary>
    /// Clase Gestor, contiene acceso a todos los metodos de la clase Bebida
    /// </summary>
    sealed class Gestor
    {
        /// <summary>
        /// Intancia de una Bebida
        /// </summary>
        private Bebida _Bebida = new Bebida();

        /// <summary>
        /// Intancia de una Gestor, para implementar patron Singleton
        /// </summary>
        private static Gestor instancia = null;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        private Gestor() { }

        /// <summary>
        /// Metodo que aplica patron singleton y devuelve su instancia
        /// </summary>
        /// <returns>Instancia de gestor</returns>
        public static Gestor GetInstance()
        {
            if (instancia == null)
            {
                return instancia = new Gestor();
            }
            else
            {
                return instancia;
            }
        }

        /// <summary>
        /// Metodo que agrega el ingrediente, al metodo ubicado en la
        /// clase Bebida, el cual ingresa un ingrediente en la lista
        /// </summary>
        /// <param name="pIngrediente">Ingrediente a agregar</param>
        /// <returns>No retorna</returns>
        public void AgregaIngrediente(Ingrediente pIngrediente)
        {
            _Bebida.AgregarIngrediente(pIngrediente);
        }

        /// <summary>
        /// Metodo que agrega un tipo de liquido, al metodo ubicado en la
        /// clase Bebida, el cual asigna un valor al tipo de liquido de la
        /// bebida creada
        /// </summary>
        /// <param name="pLiquido">Tipo de liquido</param>
        /// <returns>No retorna</returns>
        public void AsignarLiquido(Liquido pLiquido)
        {
            _Bebida.AsiganarLiquido(pLiquido);
        }

        /// <summary>
        /// Metodo que invoca el metodo de Calorias de la clase Bebida, y lo retorna
        /// </summary>
        /// <returns>Cantidad de calorias de los ingredientes y la bebida</returns>  
        public double Calorias()
        {
            return _Bebida.Caloria();
        }

        /// <summary>
        /// Metodo que invoca el metodo de Costo de la clase Bebida, y lo retorna
        /// </summary>
        /// <returns>Costo de la bebida con impuestos incluidos</returns>    
        public double Costo()
        {
            return _Bebida.Costo();
        }

        /// <summary>
        /// Metodo que invoca el metodo de ToString de la clase Bebida, y lo retorna
        /// </summary>
        /// <returns>XML creado</returns>
        public override string ToString()
        {
            return _Bebida.ToString();
        }
    }
}
