using POO1;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creo una nueva instancia de la clase persona, utilizando su constructor
        Persona p1 = new Persona("Ezequiel");

        //Seteo o caro la edad mediante su funcion
        p1.setEdad(35);

        //Muestro por consola la llamada a la funcion saludar de la clase persona
        Console.WriteLine(p1.saludar());
        Console.WriteLine(p1.saludar("Micaela"));

        //Muestro por pantalla mediante la funcion get la edad de la persona
        Console.WriteLine("la edad de la persona es: " + p1.getEdad());


        //Botella b1 = new Botella();
        //Console.WriteLine("La capacidad Actual es: " + b1);
        //b1.Capacidad = 500;

        //int algo = b1.Capacidad;
        //Console.WriteLine("la capacidad es: " + algo);

        Perro feli = new Perro();
        feli.Nombre = "Felhi";
        feli.Raza = "Puro perro";
        feli.Color = "Marron";

        Console.WriteLine("mi perrita se llama " + feli.Nombre + " es de raza " + feli.Raza + " y es de color " + feli.Color + " "+ feli.GetHashCode());

        Botella bote1 = new Botella("roja", "vidrio");
        //bote1.Capacidad = 500;
        Console.WriteLine("Capacidad de la botella " + bote1.Capacidad);
        Console.WriteLine("La cantidad actual es " + bote1.CapacidadActual);
        bote1.Recargar();
        Console.WriteLine("Luego de la recarga es La cantidad actual es " + bote1.CapacidadActual + "el monto es "+ bote1.Monto);

        //Console.WriteLine(bote1.Material + bote1.Color + bote1.Capacidad);

        Console.ReadKey();


    }
}