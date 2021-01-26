using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Class
{
    class Drink :  Snack
    {
        public Drink()
        {
            Precio = 999;
        }
        public override double MontoTotal()
        {
            return Precio;
        }

    }
}
