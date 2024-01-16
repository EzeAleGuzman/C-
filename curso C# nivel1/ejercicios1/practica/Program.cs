using System;
using System.Runtime.InteropServices;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hola ezequiel!");
            int a,b,res;
            Console.WriteLine("dime un Numero: ");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("dime un Numero: ");
            b= int.Parse(Console.ReadLine());
            res = a+b+1;
            Console.WriteLine(res);

        
        }

    }
}
