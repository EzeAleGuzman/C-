using System;

namespace maximoVector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] numeros = new int[10];

            int max, ubicacion;

            max = 0;
            ubicacion = 0;

            for (int x = 0; x < 10; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
                if (n > max ){
                    max = n;
                    ubicacion = x;
                }
            }
            Console.WriteLine("El numero mayor ingresado es : "+max +" y su posicion en el vector es: "+ubicacion);
        }
    }
}
