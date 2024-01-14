using System;

namespace funcioonPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            //instancio las variables a utilizar
            int num,totalPar, resultado;
            
            //creo uun contador y lo inicializo en 0
            totalPar=0;

            //hago un loop que solicite 20 veces un numero
            for (int x =0; x <20;x++){
                // aquisolicito el numero por consola y lo almaceno en una variable
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                //llamo a la funcion y le asigno el resultado a una nueva variable
                resultado = par(num);

                //si el valor retornado de la funcion es 1, lo sumo a mi copntador de numeros pares
                if (resultado == 1){
                    totalPar++;
                }
                //Sino continua el programa
                else {
                    continue;
                }
            }

            //Imprimo por consola Todos los datos solicitados
            Console.WriteLine("El numero total de pares es: " + totalPar);
        }
        
        //Creo una funcion que va a devolover un entero, solicitando un numero
        static int par(int num){
            //si el numero es divisible por 2(es par) retorno un 1
            if (num % 2 == 0)
                return 1;
            //Sino Retorno un 0
            else
            {
                return 0;
            }
        }
    }
}
