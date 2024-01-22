using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Botella
    {

        //Constructor de la clase botella
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 70;
            monto = 50;
        }

        //Sobrecarga de constructor
        public Botella() { }


        //Destructor lleva ~
        ~Botella()
        {
            //LLeva la logica aqui dentro.
        }


        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        private float monto;

        public float Monto
        {
            get { return monto; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CapacidadActual 
        {
            get { return cantidadActual; }
        }
        public string  Material 
        { 
            get  { return material; } 
        }

        public string Color
        { 
            get { return color; }
        }

        //Propiedad
        //public int Capacidad 
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //Metodo para cargar botella

        public float Recargar()
        {
            //si la botella tiene una cantidad actual, saca el porcentaje del monto total que se debe pagar
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                //100 50
                //dif
                monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            //si la botella esta vacia, se carga completa y el monto mantiene su valor
            cantidadActual = 100;
            return monto;
        }
    }
}
