using System;

namespace ComisionEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
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
