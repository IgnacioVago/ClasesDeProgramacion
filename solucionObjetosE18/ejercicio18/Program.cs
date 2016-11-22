using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18_program
{
    public class Program
    {
        static void Main(string[] args)
        {
            ejercicio18_computadora.Computadora compuUno;
            compuUno = new ejercicio18_computadora.Computadora(true, ejercicio18_marca.EMarca.Toshiba, ejercicio18_procesador.EProcesador.Intel_Core_i7, 17);

            /*compuUno.setEstaEncendida(true);
            compuUno.setMarca(ejercicio18_marca.EMarca.Toshiba);
            compuUno.setPeso(80);
            compuUno.setProcesador(ejercicio18_procesador.EProcesador.Intel_Core_i7);

            Console.WriteLine("\nEsta encendida: " + compuUno.getEstaEncendida());
            Console.WriteLine("\nMarca: " + compuUno.getMarca());*/
            Console.ReadLine();

        }
    }
}
