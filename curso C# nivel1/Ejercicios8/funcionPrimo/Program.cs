using System;

namespace funcionPrimo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            
            int num, resultado, contador,totalNum;

            Console.WriteLine("escriba un numero: ");
            num = int.Parse(Console.ReadLine());
            contador = 0;
            totalNum = 0;
            while (num != 0){
                totalNum++;
            resultado = Primo(num);
            if (resultado == 1){
                contador++;
            }
            Console.WriteLine("Desea agregar otro numero ");
            Console.WriteLine("Desea cerrar el programa ingrece 0 ");
            num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El porcentaje de numeros primos es : "+(contador*100/totalNum)+"%");
        }

        static int Primo(int num){

            bool esprimo = true;

            for (int x=2; x < num; x++){
                if (num %2 == 0 || num % x == 0 ){
                    esprimo = false;
                    break;
                }
            }
            if (esprimo){
                return 1;
            }
            else {
                return 0;
            }

        }
    }
}
