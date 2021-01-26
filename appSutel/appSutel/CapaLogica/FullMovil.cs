using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Bebidas.Class;

namespace UTN.WinForms.Sutel.CapaLogica
{
    class FullMovil : Llamada
    {
        Bebida bebida = null;

        public override double Costo()
        {
            double monto = 0;
            if (Duracion >= 1 && Duracion <= 10)
                monto= Duracion * 15;
            if (Duracion >= 11 )
                monto= Duracion * 25;

            return monto + Impuesto(monto);
        }


    }
}
