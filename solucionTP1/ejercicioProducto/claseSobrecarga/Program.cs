using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto prod1 = (Producto)33;
            int resultado;
            resultado = prod1 + prod1;

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();
        }
    }
}
