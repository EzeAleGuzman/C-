using System;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
          
        /*3. Hacer una función llamada “primo” que reciba un número entero
        y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números.
        El lote corta cuando se ingresa un número cero.
        Informar el promedio teniendo en cuenta sólo los números primos.*/
       
        int n, conpri= 0, acupri = 0, prom;
        Console.WriteLine("ingrese un numero");
        n = int.Parse(Console.ReadLine());
            while(n != 0){
            if(primo(n)){
            conpri ++;
            acupri += n;
            }
            Console.WriteLine("ingrese otro numero");
            n = int.Parse(Console.ReadLine());
          }  
            prom = acupri / conpri;
            Console.WriteLine("el promedio es:" + prom);

static bool primo(int a){
            int con = 0;
            for(int x = 1; x <= a; x++)
            {
            if (a % x == 0)
                con++;
            }

            if(con == 2)
                return true;
            else
                return false;
            }
           
            }
        }
    }
        
