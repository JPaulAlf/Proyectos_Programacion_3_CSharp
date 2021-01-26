using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Boleto.Clases
{
    class Normal : Boleto
    {
        public override double Monto()
        {
            double monto = 0D;
            if (this.HasEquipaje)
                monto += 25;

            monto += _Destino.Costo;
            return monto;
        }

        public override double Tax()
        {
            return Monto()*.13;
        }

        public override double Total()
        {
            return  Tax() + Monto();
        }
    }
}
