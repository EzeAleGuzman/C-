using System;

namespace TiempodeViaje
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

        // Instancio las variables
        int distancia, velocidad, resultado;

        // Solicito la distancia por pantalla
        Console.WriteLine("Distancia Entre Ciudades: ");
        // Capturo el valor y lo asigno a mi variable
        distancia = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', 50));
        // Solicito La velocidad por pantalla
        Console.WriteLine("velocidad Promedio: ");
        // Capturo el valor y lo asigno a su variable
        velocidad = int.Parse(Console.ReadLine());

        // Realizo la operacion y asigno el resultado a una nueva variable
        resultado = distancia / velocidad;
        Console.WriteLine(new string('*', 50));
        Console.WriteLine(new string('*', 50));
        //muestro el resultado por consola
        Console.WriteLine("El tiempo estimado de viaje es de " + resultado.ToString("0.00") + " Horas");

        }
    }
}
