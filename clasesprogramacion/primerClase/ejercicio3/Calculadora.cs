using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class Calculadora
    {
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Dividir(int numero1, int numero2)
        {
            if (Calculadora.ValidarSiEsCero(numero2))
            {
                return 0;
            }
            else
            {
                return numero1 / numero2;
            }
        }

        public static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private static bool ValidarSiEsCero(int num)
        {
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidarSiEsPar(int num)
        {
            if (num%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// me devuelve true si el numero ingresado devuelve el limite
        /// </summary>
        /// <param name="limite">este es el limite que debe ser superado</param>
        /// <param name="num">este el numero que debemos verificar si supera el limite</param>
        /// <returns></returns>
        public static bool EsMayorQue(int limite, int num)
        {
            if (num > limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}