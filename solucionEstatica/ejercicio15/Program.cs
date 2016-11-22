using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double numeroUno;
            double numeroDos;
            string operando;

            Console.Write("\nIngrese el primer numero: ");
            numeroUno = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el segundo numero: ");
            numeroDos = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el operando que desea usar \n* = multiplicacion \n/ = division \n+ = suma \n- = resta \nOperando: ");
            operando = Console.ReadLine();

            Console.Write("\n*****************************************************************************");

            resultado = Calculadora.Calcular(numeroUno, numeroDos, operando);

            Calculadora.Mostrar(resultado);
            Console.ReadLine();

        }
    }
}
