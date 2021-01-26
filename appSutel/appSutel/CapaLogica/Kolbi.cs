using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Sutel.CapaLogica
{
    class Kolbi : Llamada
    {
        public override double Costo()
        {
            double monto = 0;
            if (Duracion >= 1 && Duracion <= 5)
                monto= Duracion * 30;
            if (Duracion >= 6 && Duracion <= 15)
                monto= Duracion * 25;
            if (Duracion >= 16)
                monto= Duracion * 20;

            return monto + Impuesto(monto);
        }

     
    }
}
