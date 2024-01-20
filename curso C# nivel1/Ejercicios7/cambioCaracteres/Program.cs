using System;

namespace cambioCaracteres
{
    class Program
    {
        static void Main(string[] args)




    {
//             Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"



        // Solicito por pantalla la frase a modificar
        Console.WriteLine("Ingresa la frase a modificar: ");
        string cadena = Console.ReadLine();

        //solicito los caracteres a modificar 
        Console.WriteLine("Ingresa el caracter que quieres cambiar: ");
        char original = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el caracter remplazante: ");
        char remplazo = char.Parse(Console.ReadLine());

        

        // llamo a la funncion cambiar caracter y imprimo por pantalla el resultado
        cadena = CambiarCaracter(cadena, original, remplazo);
        Console.WriteLine("Cadena modificada: " + cadena);
    }

    static string CambiarCaracter(string input, char original, char remplazo)
    {
        // Convertir la cadena a un arreglo de caracteres para poder modificar los elementos usando la funcion ToCharArray().
        char[] caracteres = input.ToCharArray();

        // dentro del loop modifico los carateres que coincidan con mi 
        for (int i = 0; i < caracteres.Length; i++)
        {
            if (caracteres[i] == original)
            {
                caracteres[i] = remplazo;
            }
        }
        // Convertir el arreglo de caracteres de nuevo a una cadena usando la funcion new string().
        string resultado = new string(caracteres);

        return resultado;

    }
        
    }
}
