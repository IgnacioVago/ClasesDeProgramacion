using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int contador = 0;
            int acumulador = 0;
            int promedio;

            //Console.Title="Pollio Juan Martin";
            //Console.Write("Hola Mundo");
            //Console.ReadKey();

            for (contador = 0; contador < 5; contador++)
            {
                edad = int.Parse(Console.ReadLine());
                acumulador = acumulador + edad;
            }

            promedio = acumulador / contador;

            Console.Write("El promedio es: " + promedio);
            Console.Write(" // La suma de edades es: " + acumulador);
            
            Console.ReadKey();

            

        }
    }
}
