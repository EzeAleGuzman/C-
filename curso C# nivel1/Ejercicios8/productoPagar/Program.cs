using System;

namespace productoPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int precio,cantidad,total;

            Console.WriteLine("Ingrese Precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese La cantidad de productos: ");
            cantidad= int.Parse(Console.ReadLine());

            total = producto(precio,cantidad);
            Console.WriteLine(new string('*',50));
            Console.WriteLine("Calculador De Costo");
            Console.WriteLine(new string('*',50));

            Console.WriteLine("precio: $"+ precio+ "\nCantidad :"+cantidad);
             Console.WriteLine(new string('-',50));
            Console.WriteLine("El total es: $"+ total);
           
            Console.WriteLine(new string('*',50));
            Console.WriteLine("Fin del programa");
        }

        static int producto(int a, int b){
            int pro;
            pro = a * b;
            return pro;
        }
    }
}
