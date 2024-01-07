using System;

namespace mayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Instancio las variables que voy a utilizar
        int num, numMay, numMen, PrimerNumero, x;

        //Solicito el Primer numero que me va a ayudar de referencia para compararlos luego
        Console.WriteLine("Dime un numero: ");
        PrimerNumero = int.Parse(Console.ReadLine());

        //Asigno es valor a mis variables de mayor y menor
        numMay = PrimerNumero;
        numMen = PrimerNumero;

        //hago un bucle Pidiendo los demas numeros y comparandolos para ir sabiendo coual es mayor y menor
        for (x=1;x < 20; x++) {
        Console.WriteLine("Dime un numero: ");
        num = int.Parse(Console.ReadLine());  

        //si el numero es mayor lo almaceno en la variable numMay
        if (num >= numMay) {
            numMay = num;
        }
        //si el numero es menor lo almaceno en numMen
        else if (num <= numMen){
            numMen = num;
        }

        
        }

        //Muestro por Consola en Mayor y el menor
        Console.WriteLine("El numero mayor ingresado es : " + numMay + " El numero Menor es: " + numMen);
    }
}
}