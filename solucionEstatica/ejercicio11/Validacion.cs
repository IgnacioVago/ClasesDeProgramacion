using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Validacion
    {
        public static bool Validar(int maximo, int minimo, int numero)
        {
            if (numero > minimo && numero < maximo)
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
