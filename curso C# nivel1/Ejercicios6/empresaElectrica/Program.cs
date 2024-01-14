using System;

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

            //instamcio las variables
            int zona, usuario, usuarios, consumo, consumoTotal, proConsumo;
            double costo = 0, costoTotal = 0;
            //me sirve para saber la cantidad de usuarios
            usuarios = 0;
            consumo = 0;
            consumoTotal = 0;

            //Saludo de ingreso al Programa
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("BIENVENIDO AL CAlCULADOR DE FACTURACION POR ZONAS");
            Console.WriteLine(new string('*', 50));




            //Solicito el primer numero de zona
            Console.WriteLine("Ingrese el numero de Zona: ");
            zona = int.Parse(Console.ReadLine());

            //Cuando el numero de Zona sea distinto a 0
            while (zona != 0)
            {

                //Solicita el numero de numero de usuario y el consumo del mismo, y luego los asigna a sus variables
                Console.WriteLine("Ingrese numero de usuario: ");
                usuario = int.Parse(Console.ReadLine());
                Console.WriteLine("Conasumo del Usuario : ");
                consumo = int.Parse(Console.ReadLine());
                //si usuario es igual a 0 cierra la carga de usuarios
                while (usuario != 0)
                {
                    //agrego al contador de usuarios
                    usuarios++;

                    /*calculamos el costo con respecto al consumo 
                    el precio es escalonado según la siguiente escala
                    $ 0.10 por kv por los primeros 100 kv de consumo
                    $ 0.12 por kv por el consumo de 101 a 200 kvs
                    $ 0.15 por kv por el consumo de 201 kvs en adelante */
                    if (consumo <= 100)
                    {
                        costo = consumo * 0.10;
                    }
                    else if (consumo <= 200)
                    {
                        costo = 100 * 0.10 + (consumo - 100) * 0.12;
                    }
                    else
                    {
                        costo = 100 * 0.10 + 100 * 0.12 + (consumo - 200) * 0.15;
                    }
                    // el costo del consumo de cada usuario lo sumamos y lo almacenamos en una variable
                    costoTotal += costo;
                    //luego pedimos otro numero de usuario
                    Console.WriteLine("Ingrese numero de usuario: ");
                    usuario = int.Parse(Console.ReadLine());
                    //otra vez comprobamos que el numero no sea cero para evitar cargar el consumo, si ya no vamos a cargar mas usuarios
                    if (usuario == 0)
                    {
                        break;
                    }
                    //si es distinto a 0 volvemos a pedir el consumo
                    Console.WriteLine("Cual fue su consumo : ");
                    consumo = int.Parse(Console.ReadLine());
                }
                //imprimimos los datos pedidos en la consigna cuando terminamos de cargar los datos de la zona
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("Zona: " + zona + "\nCantidad de usuarios de la zona: " + contador + "\nTotal facturado en la zona: $" + costoTotal);
                Console.WriteLine(new string('*', 50));

                //Solicito nuevamente el numero de zona para poder ingresar nuevamente al bucle
                Console.WriteLine("Dime el numero de la zona: ");
                zona = int.Parse(Console.ReadLine());
                //Reinicio el contador de usuarios al cambiar de zona
                contador = 0;
                //reinicio el consumo luego de cambiar de zona
                consumo = 0;
            }
        }
    }
}

//Cosas por agregar
//Almacenar resulrado del bucle principal y mostrarlo luego de toda la ejecucion
//Actualizar Centrado de algunas palabras



