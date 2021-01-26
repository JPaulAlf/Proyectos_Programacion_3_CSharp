using System;
using System.Collections.Generic;
using System.Text;

namespace CapaObjetos
{
   public class Moto : Transporte

    {
        String tipoMoto;

        public String TipoMoto
        {
            get { return tipoMoto; }
            set { tipoMoto = value; }
        }
       public Moto()
           : base()
       {
           TipoMoto = "";

       }


     public Moto(string placa,  int kilometraje, int modelo, string tipoMoto)
            :base(placa,  modelo, kilometraje)
        {
            TipoMoto = tipoMoto;
       
        }

        public override double gastoCombustible()
        {
            double resultado = 0;
            if (Modelo <= 1970)
                resultado = Kilometraje * 300;
            else
                resultado = Kilometraje * 150;
            return resultado;
        }

        public override bool asignaLlantas(Llanta unaLlanta)
        {
            //Maximo permitido son 2 llantas
            if (this.ArrayLlantas.Count < 2)
            {
                this.ArrayLlantas.Add(unaLlanta);
                return true;
            }
            else
            {
                return false;
            }

        }
       public override string ToString()
       {
           return "Moto: " + TipoMoto + base.ToString();
       }



        
   
    }
}
