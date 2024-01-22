using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Perro
    {
        private string color;
        private string raza;
        private string nombre;

        public string Color
        {
            get { return color; } 
            set {  color = value; }   
        }

            
        public string Raza 
        {  
            get { return raza; } 
            set {  raza = value; } 
        } 

        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

    }
}
