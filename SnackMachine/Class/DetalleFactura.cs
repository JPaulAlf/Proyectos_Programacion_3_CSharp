using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachine.Class
{
    class DetalleFactura
    {
        public List<Snack> ListaSnacks = new List<Snack>();
        public void AddSnack(Snack pSnack)
        {
            ListaSnacks.Add(pSnack);
        }
        public void DeleteSnack(Snack pSnack)
        {
            ListaSnacks.Remove(pSnack);
        }

        public double GetMontoFactura()
        {
            double monto = 0d;
            foreach (var item in ListaSnacks)
            {
                monto += item.MontoTotal();
            }
            return monto;
        }
    }
}
