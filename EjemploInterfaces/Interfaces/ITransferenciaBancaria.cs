using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    interface ITransferenciaBancaria : ICuentaBancaria
    {
        bool TransferirA(ICuentaBancaria destino, decimal monto);       
    }
}
