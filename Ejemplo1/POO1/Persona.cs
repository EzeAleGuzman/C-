using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Persona
    {

        // Persona: Edad, Sueldo,Nombre
        //atributos
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }
         

        //Metodos (Comporta de la clases) 
        public string saludar()
        {
             return "Hola como va " + nombre;
        }

        // sobrecarga de Metodos

        public string saludar(string nombre)
        {
            return "hola " + nombre + " soy..."+ this.nombre;
        }
        

    }
}
