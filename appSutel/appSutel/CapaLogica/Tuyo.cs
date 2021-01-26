using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Sutel.CapaLogica
{
    class Tuyo : Llamada
    {
        public override double Costo()
        {
            double monto = 0;
            if (Duracion >= 1 && Duracion <= 10)
                monto= Duracion * 28;
            if (Duracion >= 11 && Duracion <= 20)
                monto= Duracion * 22;
            if (Duracion >= 21)
                monto= Duracion * 18;

            return monto + Impuesto(monto);
        }

       
    }
}
