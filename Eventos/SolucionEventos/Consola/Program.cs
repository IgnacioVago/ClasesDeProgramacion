using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona unaPersona;
            unaPersona = new Persona();
            unaPersona.MostrarNombre("Carlos");*/
            
            string dato = "Juan Martin";
            ExtensorDeEventos.miMetodo(dato);
            Console.ReadKey();
        }
    }
}
