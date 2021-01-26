using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Boleto.Clases
{
    class PrimeraClase : Boleto
    {
        #region Propiedades clase
        public bool HasAnimales { get; set; }
        public bool HasOtros { get; set; }
        #endregion


        public override double Monto()
        {
            double monto = 0D;
            monto += 200;

            if (this.HasAnimales)
                monto += 50;
            if (this.HasEquipaje)
                monto += 25;
            if (this.HasOtros)
                monto += 100;

            monto += _Destino.Costo;
            return monto;
        }

        public override double Tax()
        {
            return Monto()* .13;
        }

        public override double Total()
        {
            return  Tax() + Monto();
        }
    }
}
