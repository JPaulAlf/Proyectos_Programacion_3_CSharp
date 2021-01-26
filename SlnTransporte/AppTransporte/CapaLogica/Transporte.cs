using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CapaObjetos
{
    public abstract class Transporte
    {
        private Motor miMotor;
        private string placa;
        
        private int modelo;
        private int kilometraje;
        private ArrayList arrayLlantas;

     
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        

        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        

        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        public ArrayList ArrayLlantas
        {
            get { return arrayLlantas; }
            set { arrayLlantas = value; }
        }
   
        
        //Constructor      
        public Transporte()
        {
            this.Placa = "0";
            this.Modelo = 0;
            this.Kilometraje = 0;
            this.arrayLlantas = new ArrayList();

        }
       
        public Transporte(string placa, int modelo,
                          int kilometraje)
        {
            this.Placa = placa;
            this.Modelo=modelo;
            this.Kilometraje = kilometraje;
            this.arrayLlantas= new ArrayList();

        }
        public void asignaMotor(int pistones, string combustible)
        {
            miMotor = new Motor(pistones, combustible);
        }

        
        // métodos abstractos 

        public abstract double gastoCombustible();
        public abstract bool asignaLlantas(Llanta unaLlanta);

        

        
        public override string ToString()
        {
            StringBuilder hilera = new StringBuilder("");

            hilera.Append("\nPlaca: " + this.Placa );
            hilera.Append(" Modelo : " + this.Modelo + " Kilometraje: " + this.Kilometraje );
            
            if (miMotor != null)
            {
                hilera.Append(miMotor.ToString());
            }
            //colección de datos
            if (arrayLlantas.Count > 0)
            {
                hilera.Append("\nLlantas del medio de transporte: ");
                foreach (Llanta llanta1 in arrayLlantas)
                {
                    hilera.Append("\nLlanta " + llanta1.ToString());
                }
            }
            
            return hilera.ToString();
        }

    }
}
