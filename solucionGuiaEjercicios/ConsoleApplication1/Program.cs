using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.   
               Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/
            Console.Title = "Ejercicio 3";

            int contador;
            int numero;
            int primo;
            int acumulador;

            Console.Write("\nIngrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for(contador = 1; contador <= numero ; contador++)
            {
                acumulador = 0;

                for (primo = 1; primo <= contador; primo++)
                {
                   if (contador % primo == 0)
                   {
                       acumulador++;
                   }
                }

                if (acumulador == 2)
                {
                    Console.WriteLine("Primo: "+contador);
                }

            }

            Console.ReadKey();
        }
    }
}
