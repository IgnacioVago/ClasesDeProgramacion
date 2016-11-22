using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            /*
             *  Escribir un programa que determine si un año es bisiesto.  
             *  Un año es bisiesto si es múltiplo de 4. 
             *  Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
             *  Por ejemplo: el año 2000 es bisiesto pero 1900 no. 
             */

            int anio;

            Console.Write("\nIngrese año: ");
            anio = int.Parse(Console.ReadLine());

            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
            {
                Console.WriteLine("El año "+anio+" es bisiesto");
            }
            else
            {
                Console.WriteLine("El año "+anio+" no es bisiesto");
            }


            Console.ReadKey();

        }
    }
}
