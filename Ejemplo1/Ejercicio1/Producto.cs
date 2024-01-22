using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string tipo;
        private int stock;
        
        //Constructor de Clase Producto.
        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            stock = 0;
        }

        public int Stock
        {
            get { return stock; }
        }
        public string Descripcion
        {
            get {  return descripcion; }

            set { descripcion = value; }
        }

        public string Tipo 
        { 
            get { return tipo; } 
            set {  tipo = value; } 
        
        }


        public int Comprar(int cantidad)
        {
            stock += cantidad;
            return stock;

        }

        public int Vender(int cantidad)
        {
            if ((stock - cantidad) > 0)
            {
                stock -= cantidad;
                return stock;
            }
            else {
                stock = -1;
                   return stock ; }
        }
           
        
    }
}
