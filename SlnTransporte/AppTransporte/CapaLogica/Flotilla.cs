using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CapaObjetos
{
    public class Flotilla
    {
        private ArrayList autos;
        private string nombre;

        public ArrayList Autos
        {
            get { return autos; }
            set { autos = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Flotilla(string nombre)
        {
            this.Nombre = nombre;
            autos = new ArrayList();
        }

        public void agregarAuto(Transporte unTransporte)
        {
            autos.Add(unTransporte);
        }

        public string mayorGasto()
        {
            string placaMayor = "";
            double mayor = 0;
            if (autos != null)
            {
                foreach (Transporte unTransporte in autos)
                {
                    if (unTransporte.gastoCombustible() > mayor)
                    {
                        mayor = unTransporte.gastoCombustible();
                        placaMayor = unTransporte.Placa;
                    }
                }
                
            }
            return placaMayor;
        }

        public override string ToString()
        {
            StringBuilder hilera = new StringBuilder("");

            hilera.Append("\nFlota: " + this.Nombre);
            hilera.Append( "\nAutos que le pertenecen: \n");
            if (autos != null)
            {
                foreach (Transporte unTransporte in autos)
                {
                    hilera.Append(unTransporte.ToString());
                    hilera.Append("\n*************************************************\n");
                }
            }

            return hilera.ToString();

        }
    


    }
}
