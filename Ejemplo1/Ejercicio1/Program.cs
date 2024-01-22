using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Telefono t1 = new Telefono("1100", "nokia");
            t1.numeroTelefonico = "1155845764";
            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Ezequiel"));
            Console.WriteLine("Mi telefono es marca " + t1.Marca + " Modelo " + t1.Modelo + " y mi numero es : " + t1.numeroTelefonico);

            Producto p1 = new Producto(1,"yerba");
            p1.Descripcion = "Yerba Playadito de 1/2 kilo ";
            p1.Tipo = "Almacen";
            Console.WriteLine("el stock antes de la compra es " + p1.Stock);
            p1.Comprar(150);
            Console.WriteLine("el stock luego de la compra es: " + p1.Stock);
            p1.Vender(20);
            Console.WriteLine("El stock luego de la venta: " + p1.Stock);
            p1.Vender(150);
            Console.WriteLine("el stock ahora es: " + p1.Stock);

            Console.ReadKey();

        }
    }
}
