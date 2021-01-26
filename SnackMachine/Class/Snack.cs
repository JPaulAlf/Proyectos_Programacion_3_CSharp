using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Class
{
    abstract class Snack
    {
        protected double Precio { get; set; } = 0d;

        public abstract double MontoTotal();
        public override string ToString()
        {
            return GetType().Name;
        }
        protected double Impuesto()
        {
            return Precio * 0.13;
        }
    }
}
