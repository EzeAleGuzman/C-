using System;

namespace articulosEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.*/
            
            
            
            int articulo;
            int cantidadVenta;
            int[] totalVendido = new int[15];
            for (int x = 0; x < totalVendido.length; x++)
            {
                totalVendido[x] = 0;
            }

            Console.WriteLine("Ingrese el numero de articulo: ")
                articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad vendida: ")
                CantidadVendida = int.Parse(Console.ReadLine());


            while (articulo != 0)
            {

                totalVendido[articulo - 1] +=cantidadVenta;

                Console.WriteLine("Ingrese el numero de articulo: ")
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cantidad vendida: ")
                CantidadVendida = int.Parse(Console.ReadLine());


            }

            //Punto a
            int maxCantidad = totalVendido [0]
            int maxArticulo = 1;
            for (int x = 0; x < length; x++)
            {
                maxCantidad = totalVendido[x];
                articulo = x+1;
            }
            Console.WriteLine(maxCantidad + " " + maxArticulo);



            //punto b 
            for (int x = 0; x < length; x++)
            {
                if (totalVendido[x]== 0){
                    Console.WriteLine("El producto"+ (x + 1) +" No tuvo venta" )
                }
            }

            //punto c
            Console.WriteLine("la Cantidad vendida del articulo 10 es : "+ totalVendido[9]);
        }
    }
}
