using System;

namespace ComisionEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancio las variables
            int totalFacturado, comision, sueldoFijo, sueldoFinal;
            // Asigno la variable conocidad que es el sueldo fijo
            sueldoFijo = 15000;

            //solicito por consola el total facturado del empleado en el mes
            Console.WriteLine("Total facturado en el mes: ");   
            //capturo por pantalla el valor y le asigno una variable
            totalFacturado = int.Parse(Console.ReadLine());
            
            //Realizo la operacion y asigno la comision
            comision = (int)(totalFacturado * 0.05);

            //realizo la operacion para calcular el sueldo final y asigno su variable
            sueldoFinal = sueldoFijo + comision;

            //imprimo por consola el valor del sueldo final
            Console.WriteLine("El Sueldo final con comisiones es: " + sueldoFinal);
        }
    }
}
