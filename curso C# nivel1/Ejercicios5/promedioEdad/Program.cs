using System;

namespace promedioEdad
{
    class Program
    {
        static void Main(string[] args)
        {
        //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
        int x, edad, contador, sumaEdad, promedad;

        contador = 0;
        sumaEdad = 0;

        for (x=0;x<20;x++){
            Console.WriteLine("Dame la Edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad>=18){
                sumaEdad+= edad;
                contador++;
            }
        }
        promedad= sumaEdad / contador;
        Console.WriteLine("El Promedio de edad de los mayores es: " + promedad.ToString("0.00"));


        }
    }
}
