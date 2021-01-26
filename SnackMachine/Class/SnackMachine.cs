using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.SnackMachine.Interaces;

namespace UTN.Winform.SnackMachine.Class
{
    class SnackMachine
    {
        private List<Snack> ListaStockSnacks = new List<Snack>();
        private IMoney _Money;
        private Factura _Factura;

        public SnackMachine()
        {
            _Money = new Money();
            _Factura = new Factura();
        }
        public void AddMoney(double pMonto)
        {
            _Money.addMoney(pMonto);
        }

        public void AddSnack(Snack pSnack)
        {
            ListaStockSnacks.Add(pSnack);
        }
        public bool GetSnack(Snack pSnack)
        {
            bool respuesta = false;
            if (HasSnacks(pSnack))
            {
                respuesta = GetOutFromSnackStock(pSnack);
                _Factura.AddSnack(pSnack);
            }
            else
            {
                throw new Exception("No hay snacks del solicitado !");
            }
            return respuesta;
        }

         private bool HasSnacks(Snack pSnack)
        {
            bool existe = false;
            //existe = ListaStockSnacks.Exists(p => p.GetType() ==
            pSnack.GetType();
            foreach (Snack item in ListaStockSnacks)
            {
                if (pSnack.GetType() == item.GetType())
                {
                    existe = true;
                }
            }
            return existe;
         }
        private bool GetOutFromSnackStock(Snack pSnack)
        {
            bool respuesta = false;
            //Snack pop = ListaStockSnacks.FirstOrDefault(p => p.GetType() ==
            pSnack.GetType();
            foreach (Snack item in ListaStockSnacks)
            {
                if (pSnack.GetType() == item.GetType())
                {
                    respuesta = ListaStockSnacks.Remove(item);
                    break;
                }
            }
            return respuesta;
        }
        public double GetMontoFactura()
        {
            return _Factura.GetMontoFactura();
        }
        public Factura PayBill(double pMontoPagado)
        {
            double diferencia = 0d;
            double vuelto = 0d;
            Factura tmpFactura = new Factura();
            if (_Factura.GetMontoFactura() > pMontoPagado)
            {
                throw new Exception("Falta ingresar más dinero !!!");
            }
            else
            {
                diferencia = pMontoPagado - _Factura.GetMontoFactura();
                if (_Money.GetMoney() < diferencia)
                {
                    throw new
                    Exception("No es suficiente en SnackMachine para dar vuelto !");
                }
                vuelto = _Money.SubstractMoney(pMontoPagado);
            }
            // Clonar factura
            tmpFactura = _Factura.Clone() as Factura; // (Factura) _Factura.Close()
            _Factura = new Factura();
            return tmpFactura;
        }

    }
}
