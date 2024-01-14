using System;

namespace añoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Escribir un programa que permita al usuario ingresar dos años y luego imprima todos los años en ese rango, que sean bisiestos y múltiplos de 10. Nota: para que un año sea bisiesto debe ser divisible por 4 y no debe ser divisible por 100, excepto que también sea divisible por 400.

        //instancio las variables
        int año1, año2;
        
        //las solicito por pantalla ñlos años y los asigno a su variable
        Console.WriteLine("Dime el primer año: ");
        año1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dime el segundo año: ");
        año2 = int.Parse(Console.ReadLine());

        // un loop
        for (int x= año1; x < año2;x++){
            if ((x % 4 ==0 && x % 100 != 0 )|| x % 400==0){
                Console.WriteLine(x);
            }
        }
        }
    }
}
