using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Boleto.Clases
{
  public class Pais
    {
        #region Propiedades clase
        public double Costo { get; set; }
        public string Nombre { get; set; }
        #endregion
        public Pais()
        {
            
        }
        public Pais( double costo,string nombre)
        {
            this.Nombre = nombre;
            this.Costo = costo;
        }


        public override String ToString()
        {
            return string.Format("{0} {1}", Nombre, Costo);
        }
    }
}
