﻿using System;

namespace empresaElectrica
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Una compañía de electricidad necesita calcular anualmente el consumo que ha
registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
Para ello tiene un lote de registros por cada uno de los usuarios con los
siguientes datos:
• Zona (numérico entero).
• Número de cliente (número de cuatro dígitos no correlativos).
• Cantidad de kilovatios consumidos en el periodo.
El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
con zona igual a cero.
Se pide generar un listado con el siguiente formato:
Zona: XX
Cantidad de usuarios de la zona: XX
Total facturado en la zona: XX
Zona: XX
Cantidad de usuarios de la zona: XX
Total facturado en la zona: XX
El precio es escalonado según la siguiente escala:
• $ 0.10 por kv por los primeros 100 kv de consumo.
• $ 0.12 por kv por el consumo de 101 a 200 kvs.
• $ 0.15 por kv por el consumo de 201 kvs en adelante.*/


            int zona,usuario,contador;
            contador = 0;
            Console.WriteLine("Dime el numero de la zona: ");
            zona = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el numero de usuario: ");
            usuario =int.Parse(Console.ReadLine());
            while (zona != 0){
                    while (usuario != 0) {
                        contador++;
                        Console.WriteLine("Dime el numero de usuario: ");
                        usuario = int.Parse(Console.ReadLine());
                    }
            Console.WriteLine("La cantidad de usuarios de la zona: "+zona+ "es "+contador);
            Console.WriteLine("Dime el numero de la zona: ");
            zona = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el numero de usuario: ");
            usuario =int.Parse(Console.ReadLine());
            contador = 0;
            }
        }
    }
}
