using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Interaces
{
    interface IMoney
    {
        void addMoney(double pMonto);
        double GetMoney();
        double SubstractMoney(double pMonto);
    }
}
