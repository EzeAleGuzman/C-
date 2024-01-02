using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

            // paso 0
            // Tipo de dato : Int, float, char, bool
            int n1, n2, resultado;


            // Pedir valores
            Console.WriteLine("Ingrese un numero");
            n1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            // Realizar calculo
            resultado = n1 * n2;
            // Emitir el resultado por pantalla
            Console.WriteLine("el resultado es : " + resultado);
        }
    }
}
