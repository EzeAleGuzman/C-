using System;

namespace elvadoalcuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
        // Defino las Variables
        int num, resultado;

        // Pido Por pantalla que se ingrese un nuimero
        Console.WriteLine("Ingese un numero: ");

        // igualo mi variable al ingreso por pantalla
        num = int.Parse(Console.ReadLine());

        //hago la operacion y asigno el resultado
        resultado = num * num * num;

        // imprimo por pantalla el resltado concatenando
        Console.WriteLine(" el cubo de " + num + " es " + resultado);






        }
    }
}
