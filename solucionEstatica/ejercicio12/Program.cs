using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";

             /*Realizar un programa que sume números enteros hasta que el usuario lo determine, 
              * por medio de un mensaje ―¿Continua? (S/N)‖.  En el método estático ValidaS_N() 
              * de la clase ValidarRespuesta, se validará el ingreso de opciones.  
              * El método NO recibe parámetros y devuelve un valor de tipo booleano, 
              * TRUE si se ingreso una 'S' y FALSE si se ingreso una 'N'.  
              * El método deberá validar si otro caracter fue ingresado mostrando un mensaje de error
              * y pidiendo el reingreso del mismo.
              */

            int numero;
            bool retorno;
            int acumulador = 0;

            do
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;

                retorno = ValidarRespuesta.ValidarS_N();

            } while (retorno == true);

            Console.Write("\nSuma de numeros ingresados: " + acumulador);
            Console.ReadLine();
        }
    }
}
