using System;

namespace esPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciaizo las variables
            int x, num;
            bool esPrimo;

            //Asigno un valor booleano a mi variable esPrimo
            esPrimo= true;

            //Solicito el Numero por pantalla
            Console.WriteLine("Dime el numero: ");
            num = int.Parse(Console.ReadLine());

            // creo un bucle donde x funciona como el divisor
            for (x=2; x < num ;x++){
                // Elimino los numeros pares, para hacer mas eficiente el programa y tambien busco si el resto de algguna division entre num y x da cero
                if (num % 2 == 0 || num % x == 0 ){
                    //si este resultado es afirmativocambio el valor de la variable esPrimo a falso y corto el bucle.
                    esPrimo= false;
                    break;
                }
                }
            //Si pasa el bucle y el valor de esPrimo se mantiene Imprimo que es primo
            if (esPrimo)
                Console.WriteLine("Es Primo");
            //sino imprimo que no es primo
            else
                Console.WriteLine("No es primo");
                
                
                
            }



    }
}

