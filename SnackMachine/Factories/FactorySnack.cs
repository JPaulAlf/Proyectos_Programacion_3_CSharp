using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.SnackMachine.Class;


namespace UTN.Winform.SnackMachine.Factories
{
    class FactorySnack
    {
        public static Snack CreateSnack(TipoSnack pTipo)
        {
            Snack oSnack = null;
            switch (pTipo)
            {
                case TipoSnack.Candy:
                    oSnack = new Candy();
                    break;
                case TipoSnack.Chocolate:
                    oSnack = new Chocolate();
                    break;
                case TipoSnack.Chip:
                    oSnack = new Chip();
                    break;
                case TipoSnack.Drink:
                    oSnack = new Drink();
                    break;
            }
            return oSnack;
        }
    }
}
