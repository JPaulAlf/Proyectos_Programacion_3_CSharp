using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.WinForms.Boleto.Clases;

namespace UTN.WinForms.Boleto.Factory
{
    public class FactoryBoleto
    {
        public static Clases.Boleto CreateBoleto(TipoBoleto pTipoBoleto)
        {

            Clases.Boleto oBoleto = null;

            switch (pTipoBoleto)
            {
                case TipoBoleto.Normal:
                    oBoleto = new Normal();
                    break;
                case TipoBoleto.PrimeraClase:
                    oBoleto = new PrimeraClase();
                    break;
            }
            return oBoleto;
        } // fin CrearBoleto

    }
}
