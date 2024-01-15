using System;

namespace funcionposicivoCeroNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            int num, estado;

            num = 1;
            estado = 0;
            positivoNegativoCero(num,ref estado);
            Console.WriteLine(estado);

        }

        static void positivoNegativoCero(int num,ref int estado){
            if(num < 0){
                estado = -1;
            }
            else if (num > 0) {
                estado = 1;
            }
            else {
                estado = 0;
            }

        }
    }
}
