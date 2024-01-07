using System;

namespace numMayor
{
    class Program
    {
        static void Main(string[] args)
        {

//2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

        //Instancio las variables a utilizar
        int num, x, numMayor;

        //Creo un marcador para ir guardando el numero mayor
        numMayor = 0; 

        //Realizo el bucle for pidiendo 10 numeros
        for (x=0; x<= 10; x++){ 
        Console.WriteLine("Ingrese un numero: ");
        num = int.Parse(Console.ReadLine());
        
        //dentro del bucle creo una condicion que si el numero es mayor se guarde en esa variable
        if (num > numMayor)
            numMayor = num;
        };
        //fuera del bucle para finalizar imprimo el numero mayor
        Console.WriteLine(numMayor);
        }
    }
}
