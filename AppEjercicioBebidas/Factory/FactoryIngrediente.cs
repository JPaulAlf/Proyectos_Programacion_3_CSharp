using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Bebidas.Class;

namespace UTN.Winform.Bebidas.Factory
{
    /// <summary>
    /// Clase FactoryIngrediente, construye los ingredientes
    /// </summary>
    class FactoryIngrediente
    {

        /// <summary>
        /// Metodo que fabrica el ingrediente y lo retorna
        /// </summary>
        /// <param name="pTipo">Tipo de ingrediente</param>
        /// <returns>Ingrediente</returns>
        public Ingrediente CrearIngrediente(TipoIngrediente pTipo)
        {
            Ingrediente _Ingrediente = null;
            switch (pTipo)
            {
                case TipoIngrediente.Fresa:
                    return _Ingrediente = new Fresa();         
                case TipoIngrediente.Papaya:
                    return _Ingrediente = new Papaya();    
                case TipoIngrediente.Pera:
                    return _Ingrediente = new Pera();     
                case TipoIngrediente.Pina:
                    return _Ingrediente = new Pina();
                default:
                    return _Ingrediente;
            }
        }

    }
}
