using System;

namespace ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];


            for (int x = 0; x < 10; x++)   
            {

                articulos[x] = new Articulo();
                Console.WriteLine("ingrese los datos de los productos: ");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());

            }

            //
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabaja el programa y vuelvo a pedir

                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
