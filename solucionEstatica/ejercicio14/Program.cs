using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            double lBase;
            double lAltura;
            double ladoCuad;
            double radioCirc;
            double areaCirc;
            double areaCuad;
            double areaTria;

            Console.Write("\nIngrese base del triangulo: ");
            lBase = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese altura del triangulo: ");
            lAltura = double.Parse(Console.ReadLine());

            areaTria = CalculoDeArea.CalcularTriangulo(lBase, lAltura);

            Console.Write("\n*************************************************************************");

            Console.Write("\nIngrese lado del cuadrado: ");
            ladoCuad = double.Parse(Console.ReadLine());

            areaCuad = CalculoDeArea.CalcularCuadrado(ladoCuad);

            Console.Write("\n*************************************************************************");

            Console.Write("\nIngrese radio del circulo: ");
            radioCirc = double.Parse(Console.ReadLine());

            areaCirc = CalculoDeArea.CalcularCirculo(radioCirc);

            Console.Write("\n*************************************************************************");

            Console.Write("\nArea del circulo: "+areaCirc);
            Console.Write("\nArea del triangulo: "+areaTria);
            Console.Write("\nArea del cuadrado: "+areaCuad);

            Console.Write("\n*************************************************************************");

            Console.ReadLine();
        }
    }
}
