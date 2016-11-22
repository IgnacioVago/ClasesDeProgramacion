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
            /*Ingresar 5 números por consola, guardándolos en una variable escalar. 
            Luego calcular y  mostrar: el valor máximo, el valor mínimo y el promedio.*/

            Console.Title = "Ejercicio 1";

            int numero;
            int contador;
            int promedio;
            int acumulador=0;
            int minimo=0;
            int maximo=0;
            int flag=0;

            for (contador = 0; contador < 5; contador++)
            {
                Console.Write("\nIngrese numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;

                if (flag == 0 || minimo > numero)
                {
                    minimo = numero;
                }

                if (flag == 0 || maximo < numero)
                {
                    flag = 1;
                    maximo = numero;
                }
            }

            promedio = acumulador / contador;
            Console.Write("\nPromedio: " + promedio);
            Console.Write("\nMaximo: " + maximo);
            Console.Write("\nMinimo: " + minimo);
            Console.ReadKey();
        }
    }
}
