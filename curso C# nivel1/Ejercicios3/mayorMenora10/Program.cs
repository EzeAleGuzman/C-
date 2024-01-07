using System;

namespace mayorMenora10
{
    class Program
    {
        static void Main(string[] args)
        {

        // Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
        
        int num;

        Console.WriteLine("Dame un numero: ");
        num = int.Parse(Console.ReadLine());


        if (num > 10) {
            Console.WriteLine("el numero  es mayor a 10");
        }
        else if (num < 10){
            Console.WriteLine("El numero es menor a 10");
        }
        else
        {
            Console.WriteLine("el numero es 10");
        }
       
    }
}
}