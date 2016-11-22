using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";

            double divisores;
            double acumulador = 0;
            double numero = 1;
            double contperf = 0;

            for ( ; ; )
            {
                numero++;
                acumulador = 0;

                for (divisores = 1; divisores < numero; divisores++)
                {
                    if (numero % divisores == 0)
                    {
                        acumulador = acumulador + divisores;
                    }
                }

                if (acumulador == numero)
                {
                    Console.Write("\nNumero perfecto: " + numero);
                    contperf++;
                }

                if (contperf == 4)
                {
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
