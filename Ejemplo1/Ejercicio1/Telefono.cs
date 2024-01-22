using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Telefono
    {
        //        Desafío 1
        //Hola! Cómo va?

        //Vamos a trabajar con lo aprendido en ésta unidad.
        //        Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica y ver funcionando lo visto hasta aquí.

        //Crear un proyecto de consola .Net Framework.
        //Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
        //Agregale los siguientes atributos:
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).
        //Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
        //Modelo: solo lectura. Es decir, solo get.
        //Marca: solo lectura.
        //NumeroTelefonico: lectura y escritura.
        //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
        //Agregar Constructor que reciba Modelo y Marca.
        //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
        //Estas cosas son las que hicimos con los ejemplos de Persona, Botella, Ventas; intenta ponerlos en práctica y si hay dudas, repasate lo necesario.También podés consultar al foro de dudas.

        //Te propongo pensar alguna clase más, construirla y agregarle atributos, propiedades y métodos y hacer algunas pruebas; siempre teniendo en mente que la idea es representar la realidad en lo digital.

        //No te olvides de la importancia de la práctica.

        //Saludos.


        private string modelo;
        private string marca;
        //NumeroTelefonico: lectura y escritura.
        public string numeroTelefonico { get; set; }
        private int codigoOperador;

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }   

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca 
        {
            get { return marca; } 
        }
        
        public int CodigoOperador
        {
            get { return codigoOperador;}

            //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
            set
            {
                if (1 >= codigoOperador && codigoOperador < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
                }
        }

        public string Llamar() 
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return "Realizando llamada a " + contacto;
        }

        
    }
}
