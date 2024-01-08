using System;

namespace mayorMenora10
{
    class Program
    {
        static void Main(string[] args)
        {

        // Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
        
        //Creo La intancia de las variables
        int num;

        //Solicito por consola el ingreso de un numero y lo almaceno en la variable num

        Console.WriteLine("Dame un numero: ");
        num = int.Parse(Console.ReadLine());

        //si numero es mayor a 10
        if (num > 10) {
            //improiimo por consola
            Console.WriteLine("el numero  es mayor a 10");
        }
        // si es menor 
        else if (num < 10){
            //imprimo por consola que es menor
            Console.WriteLine("El numero es menor a 10");
        }
        else
        {
            //Si el numero es igual a 10 lo imprimo por consola
            Console.WriteLine("el numero es 10");
        }
       
    }
}
}