using System;

namespace listsNum
{
    class Program
    {
        static void Main(string[] args)
        {
//             Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

// El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        int num, contador, x,mayorPor, numImp,porcenImp=0, vueltaImpar, numMayor, enOrden;
        bool ordenado;
        enOrden = 0;
        vueltaImpar = 0;
        contador = 0;
        numImp = 0;
        mayorPor = 0;
        numMenor= 0;
        ordenado= true;

        for (x=0;x < 5; x++){
            
            Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            numMenor = num;
            if (num % 2 != 0)
                    numImp++;
            while (num != 0){
                Console.WriteLine("ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                contador++;
                if (num % 2 != 0)
                    numImp++;

                if (numMenor >= num){
                    numMenor = num;
                }
                else {
                    ordenado = false;
                }
                
            }
            porcenImp = numImp * 100 / contador;
            if (porcenImp > mayorPor){
                mayorPor = porcenImp ;
                vueltaImpar= x+1;
                    }
            
             if (ordenado)
    {
        enOrden++;
    }
        }
        Console.WriteLine($"El grupo con mayor poncentaje de impares es el: {vueltaImpar} y la cantidad de grupos ordenados de mayor a menor es {enOrden}");
        




        }
    }
}
