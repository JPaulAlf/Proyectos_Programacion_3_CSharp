using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    class CuentaCorriente : ITransferenciaBancaria, ICuentaBancaria
    {
        private decimal saldo;

        #region ITransferenciaBancaria Members

        public bool TransferirA(ICuentaBancaria destino, decimal monto)
        {
            bool resultado = Retiro(monto);

            if (resultado)
            {
                destino.Deposito(monto);
            }

            return resultado;
        }       

        #endregion

        #region ICuentaBancaria Members

        public void Deposito(decimal monto)
        {
            this.saldo += monto;
        }

        public bool Retiro(decimal monto)
        {
            if (this.saldo >= monto)
            {
                saldo -= monto;
                return true;
            }
            else
                throw new ApplicationException("El monto del egreso es mayor que el disponible");
        }

        public decimal Saldo
        {
            get { return saldo; }
        }       

        #endregion

        public override string ToString()
        {
            return "Cuenta Corriente";
        }
    }
}
