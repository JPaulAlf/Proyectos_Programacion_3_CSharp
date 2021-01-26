using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Class
{
    class Chip : Snack
    {

        public Chip()
        {
            Precio = 900;
        }

        public override double MontoTotal()
        {
            return Precio + Impuesto();
        }
    }
}
