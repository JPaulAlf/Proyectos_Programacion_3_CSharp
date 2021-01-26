using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    interface ICuentaBancaria
    {
        decimal Saldo
        {
            get;
        }
        void Deposito(decimal monto);

        bool Retiro(decimal monto);
       
        
    }
}
