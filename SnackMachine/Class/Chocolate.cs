using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Class
{
    class Chocolate : Snack
    {
        
        public Chocolate()
        {
            Precio = 750;
        }
        public override double MontoTotal()
        {
            return Precio + Impuesto();
        }
    }
}
