using System;

namespace descuentoPorcentaje
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

        // Instacncio las variables
        float montoVenta,litros;

        //Las solicito por pantalla y las asigno a las variables
        Console.WriteLine(new string('*', 50));
        Console.WriteLine("Importe total de venta: ");
        montoVenta = float.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', 50));
        Console.WriteLine("Ingrese Cantidad de Litro: ");
        litros = float.Parse(Console.ReadLine());

        if (litros > 500){
            montoVenta*= 0.75F;
        }
        else if (litros > 300){
            montoVenta*= 0.85F;
        }
        else if (litros > 100 ){
            montoVenta*= 0.90F;
        }
        Console.WriteLine(new string('*', 50));
        Console.WriteLine("El monto es: $" + montoVenta.ToString("0.00"));

        }
    }
}
