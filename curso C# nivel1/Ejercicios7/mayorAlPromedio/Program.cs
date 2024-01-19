using System;

namespace mayorAlPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo el vector ara guardar numeros
            int[] numeros = new int[10];

            //creo las variables 
            int suma = 0;
            int promedio = 0;
            int num = 0;

            //creo un bucle con la cantidad de numeros que quiero
            for (int x = 0; x < 10; x++)
            {
                //solicito por pantalla los numeros y los asigno a una variable
                Console.WriteLine("Ingresa un numero : ");
                num = int.Parse(Console.ReadLine());
                //guardo los numeros en su indice correspondiente
                numeros[x] = num;
                //sumo los numeros ingresados para calcular el promedio
                suma += num;

            }
            
            //Luego de ver todos los numeros realizo el promedio
            promedio = suma / 10;
            Console.WriteLine("El Promedio total es "+ promedio);

            //imprimo por pantalla todos los numero mayores al promedio
            Console.WriteLine("Los números mayores al promedio son: ");
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x]> promedio)
                
                Console.Write(numeros[x]+".");
                
            }


        }
    }
}
