using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.SnackMachine.Interaces;

namespace UTN.Winform.SnackMachine.Class
{
    class Money :IMoney
    {
        private double Monto = 0;
        public double SubstractMoney(double pMonto)
        {
            if (Monto - pMonto < 0)
            {
                throw new Exception("No existe suficiente cantidad de dinero");
            }
            else
            {
                Monto -= pMonto;
            }
            return Monto;
        }
        public double GetMoney()
        {
            return Monto;
        }

        public void addMoney(double pMonto)
        {
            Monto += pMonto;
        }
    }
}
