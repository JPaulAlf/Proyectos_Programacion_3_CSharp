using System;
using System.Collections.Generic;
using System.Text;

namespace CapaObjetos
{
    public class Motor
    {

        
        private int Pistones {set;get;}
        private string Combustible { set; get; }
               

        #region Constructor

        public Motor(int Pistones, String Combustible)
        {
            this.Pistones = Pistones;
            this.Combustible = Combustible;
        }
        #endregion
        
        #region Métodos públicos de la clase

        public override string ToString()
        {
            StringBuilder  hilera = new StringBuilder("");
            hilera.Append("Pistones : " + this.Pistones);
            hilera.Append(" Combustible :" + this.Combustible + "\n");

            return hilera.ToString();
        }

        #endregion


    }
}
