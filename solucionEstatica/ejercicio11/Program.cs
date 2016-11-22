using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 11";

            /*
             *  Ingresar 10 números enteros que pueden estar dentro de un rango de entre 100 y -100.  
             *  Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar,
             *  que posea la siguiente firma: bool Validar(int, int, int). Terminado el ingreso mostrar el valor mínimo, 
             *  el valor máximo y el promedio.  
                Nota: Utilizar variables escalares, NO utilizar vectores. 
             */

            int numero;
            int contador;
            int acumulador = 0;
            int promedio;
            int minimo = 0;
            int maximo = 0;

            for (contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                if (Validacion.Validar(100, -100, numero) == false)
                {
                    Console.WriteLine("Error al ingresar numero");
                    Console.WriteLine("Ingrese numero nuevamente: ");
                    numero = int.Parse(Console.ReadLine());
                }

                acumulador = acumulador + numero;

                if (contador == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
            }

            promedio = acumulador / contador;

            Console.Write("Promedio: " + promedio);
            Console.Write("\nMaximo: " + maximo);
            Console.Write("\nMinimo: " + minimo);
            Console.ReadKey();



        }
    }
}
