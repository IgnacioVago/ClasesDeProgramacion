using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";

            /*
             . Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año)
             * y calcule el número de días vividos por esa persona hasta la fecha actual 
             * (tomar la fecha del sistema con DateTime.Now).   
                Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.   
             */

            int año;
            int mes;
            int dia;

            Console.WriteLine("Ingrese dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de nacimiento: ");
            año = int.Parse(Console.ReadLine());

            DateTime fechaActual = DateTime.Now;
            DateTime vivido = new DateTime(año, mes, dia);

            TimeSpan ts = fechaActual - vivido;

            int diasVividos = ts.Days;

            Console.Write("Ustedes vivio "+diasVividos+" dias");
            Console.ReadKey();
        }
    }
}
