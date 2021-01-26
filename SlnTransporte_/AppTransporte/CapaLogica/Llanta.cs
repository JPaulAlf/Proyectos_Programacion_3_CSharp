using System;
using System.Collections.Generic;
using System.Text;

namespace CapaObjetos
{
    public class Llanta
    {
        private int codLlanta;
        private string marca;
        private int medida;

        public int CodLlanta
        {
            get { return codLlanta; }
            set { codLlanta = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public int Medida
        {
            get { return medida; }
            set { medida = value; }
        }

        public Llanta()
        {
            this.medida = 0;
            this.marca = "Genérica";
        }

        //Constructor
        public Llanta(int codigo, string marca, int medida)
        {
            
            this.Medida= medida;
            this.Marca= marca;
        }


        public override string ToString()
        {
            StringBuilder hilera = new StringBuilder("");
            hilera.Append( this.marca + " " + this.medida + " pulgadas");
            return hilera.ToString();
        }
    
    }
}
