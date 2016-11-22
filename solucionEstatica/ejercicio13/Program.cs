using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            string resultado;
            double numero;
            string binario;
            double resultadoDos;

            Console.Write("Ingrese un número decimal positivo: ");
            numero = double.Parse(Console.ReadLine());

            resultado = Conversor.DecimalBinario(numero);
            Console.Write("Numero escrito en binario: "+resultado);
            Console.ReadLine();

            Console.WriteLine("***********************************************");

            Console.Write("Ingrese un número binario: ");
            binario = Console.ReadLine();

            resultadoDos = Conversor.BinarioDecimal(binario);
            Console.Write("Numero escrito en binario: " + resultadoDos);
            Console.ReadLine();
        }
    }
}
