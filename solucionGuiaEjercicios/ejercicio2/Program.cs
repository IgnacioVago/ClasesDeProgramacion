using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: 
             * "ERROR. Reingresar número!!!". 
              Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación*/
            Console.Title = "Ejercicio 2";

            double numero;
            double numeroCuadrado;
            double numeroCubo;

            Console.Write("\nIngrese numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.Write("\nERROR, reingrese el numero!!!");
                Console.Write("\nIngrese numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            numeroCuadrado = Math.Pow(numero, 2);
            numeroCubo = Math.Pow(numero, 3);

            Console.Write("\nNumero al cuadrado: " + numeroCuadrado);
            Console.Write("\nNumero al cubo: " + numeroCubo);
            Console.ReadKey();
        }
    }
}
