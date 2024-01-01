using System;

namespace NotasPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancio las variables
            int nota1, nota2, nota3, promedio;

            //pido por pantalla y asigno el valor a las variables
            Console.WriteLine("Primera Nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda Nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercera Nota: ");
            nota3 = int.Parse(Console.ReadLine());

            //hago el proceso y lo asigno a una variable
            promedio = (nota1 + nota2 + nota3) / 3;

            //muestro por consola el promedio de notas
            Console.WriteLine("El Promedio de las 3 notas es: "+ promedio);


        }
    }
}
