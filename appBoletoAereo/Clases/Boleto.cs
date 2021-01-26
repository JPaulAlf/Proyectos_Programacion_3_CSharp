using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UTN.WinForms.Boleto.Clases
{
    public abstract class Boleto 
    {
        #region Propiedades clase
        public Pais _Destino { get; set; }
        public double Fax { get; set; }
        public bool HasEquipaje { get; set; }
        public string Tipo { get; set; }
        #endregion

        public abstract double Monto();
        public abstract double Tax();
        public abstract double Total();
    }
}
