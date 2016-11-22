using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double areaCuadrado;

            areaCuadrado = lado * lado;

            return areaCuadrado;
        }

        public static double CalcularTriangulo(double ladoBase, double ladoAltura)
        {
            double areaTriangulo;

            areaTriangulo = (ladoBase * ladoAltura) / 2;

            return areaTriangulo;
        }

        public static double CalcularCirculo(double radio)
        {
            double areaCirculo;

            areaCirculo = (3.1416*(radio * radio));

            return areaCirculo;
        }
    }
}
