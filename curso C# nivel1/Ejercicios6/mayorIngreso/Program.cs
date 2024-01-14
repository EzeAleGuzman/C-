using System;

namespace mayorIngreso
{
    class Program
    {
        static void Main(string[] args)
        {

            //instancio las variables
            int num, mayor;
            // igualo el mayor a 0 para luego 
            mayor = 0;

            Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            while(num != 0){
                if (num > mayor){
                    mayor = num;
                }
                Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("el numero ingresado  mayor es: "+ mayor);
        }
    }
}
