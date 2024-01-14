using System;

namespace funcionPrimo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            //Instancio las variables que voy a utilizar
            int num, resultado, primo, totalNum;

            //solicito el ingreso de un numero
            Console.WriteLine("Ingrese un numero distinto a cero: ");
            num = int.Parse(Console.ReadLine());

            //inicializo los contadores de la cantidad de primos y numeros ingresados
            primo = 0;
            totalNum = 0;

            //mientras el numero sea distinto a cero
            while (num != 0)
            {
                //aumento el valor de la cantidad de numeros
                totalNum++;

                // asigno el resultado de llamar a mi funcion Primo a una variable
                resultado = Primo(num);

                //si esta variable da uno
                if (resultado == 1)
                {
                    //Sumo los numeros primos
                    primo++;
                }
                //vuelvo a solicitar que de ingrese un numero
                Console.WriteLine("Ingrese un numero distinto a cero: ");
                num = int.Parse(Console.ReadLine());
            }

            //si se ingresa cero el program,a imprime por consola el porcentaje de numeros primos
            Console.WtriteLine(new string('-',50));
            Console.WriteLine("El porcentaje de numeros primos es : " + (primo * 100 / totalNum) + "%");
        }



        //creo una funcion para saber si un numero es primo
        static int Primo(int num)
        {
            //asigno un valor booleano a es primo
            bool esprimo = true;

            //Creo el loop para recorrer todos los numeros menores a el argumento.
            for (int x = 2; x < num; x++)
            {
                //si es par o en alguna de las iteraciones da como resto 0
                if (num % 2 == 0 || num % x == 0)
                {
                    //cambio el valor de esprimo a false y termino el loop
                    esprimo = false;
                    break;
                }
            }
            //si es primo, retorno 1
            if (esprimo)
            {
                return 1;
            }
            //si no lo es, retorno 0
            else
            {
                return 0;
            }

        }
    }
}
