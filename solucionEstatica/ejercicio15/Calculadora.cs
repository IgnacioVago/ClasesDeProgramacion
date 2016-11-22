using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, string operacion)
        {
            double cuenta = 0;

            switch (operacion)
            { 
                case "+":
                    cuenta = numeroUno + numeroDos;
                    Console.Write("\nOperacion de suma realizada");
                    break;
                case "-":
                    cuenta = numeroUno - numeroDos;
                    Console.Write("\nOperacion de resta realizada");
                    break;
                case "*":
                    cuenta = numeroUno * numeroDos;
                    Console.Write("\nOperacion de multiplicación realizada");
                    break;
                case "/":
                    if (Calculadora.Validar(numeroDos) == true)
                    {
                        cuenta = numeroUno / numeroDos;
                        Console.Write("\nOperacion de división realizada");
                    }
                    else
                    {
                        Console.Write("\nUsted quiso dividir un numero por cero");
                    }
                    break;
                default:
                    Console.Write("\nERROR, no ingresó un operador correcto");
                    break;
            }

            return cuenta;
        }

        private static bool Validar(double numeroDos)
        {
            if (numeroDos != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Mostrar(double cuenta)
        {
            Console.Write("\nResultado: "+cuenta);
        }


    }
}
