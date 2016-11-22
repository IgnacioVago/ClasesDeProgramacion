using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int resulsuma;
            int resuldiv;
            int resulres;
            int resulmul;

            resulres = ejercicio3.Calculadora.Resta(6, 6);
            resulmul = ejercicio3.Calculadora.Multiplicacion(6, 6);
            resulsuma = ejercicio3.Calculadora.Sumar(6, 6);
            resuldiv = ejercicio3.Calculadora.Dividir(6, 6);
            ejercicio3.Calculadora.EsMayorQue(6, 6);

            Console.Write("\nSuma: " + resulsuma);
            Console.Write("\nDivision: " + resuldiv);
            Console.Write("\nResta: " + resulres);
            Console.Write("\nMultiplicacion: " + resulmul);
            Console.ReadKey();*/

            Alumno alguien;

            alguien = new Alumno();

            Alumno otro = new Alumno();

            otro.nombre = "Maria";
            otro.nota = 12;
            alguien.nombre = "Carlos";
            alguien.nota = 18;

            otro.MostrarDatos();
            alguien.MostrarDatos();
        }
    }
}
