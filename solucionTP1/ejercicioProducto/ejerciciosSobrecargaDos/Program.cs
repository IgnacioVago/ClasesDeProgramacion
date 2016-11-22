using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSobrecargaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar und;
            Peso unp;

            und = 1;
            unp = (Peso)1;

            //und = und + unp;
            unp = unp + und;

            //Console.WriteLine("Un dolar + un peso: " + und.cantidad);
            Console.WriteLine("Un peso + un dolar: " + unp.cantidad);
            Console.ReadLine();
        }
    }
}
