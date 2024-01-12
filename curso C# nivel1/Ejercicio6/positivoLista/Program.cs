using System;

namespace positivoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int num, contadorLista,contadorNumero;
            
            contadorLista=0;
            Console.WriteLine("Numero: ");
            num = int.Parse(Console.ReadLine());
            contadorNumero=0;
            

                while (num > 0){
                    contadorLista++;
                    while (num != 0) {
                    contadorNumero++;
                    Console.WriteLine("Numero: ");
                    num = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("la cantidad de numeros es: "+contadorNumero);
                Console.WriteLine("Numero: ");
                num = int.Parse(Console.ReadLine());
                contadorNumero=0;
                
                
            }
            Console.WriteLine("La cantidad de listas es: "contadorLista);
        }
    }
}
