using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace consolaArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona;
            unaPersona = new Persona("Juan Martin", "123456");

            Guardador.GuardarPersona(unaPersona);
            Guardador.LeerUnaPersona();

            List<Persona> listaDePersonas;
            listaDePersonas = Guardador.ListadoDePersonas();

            /*StreamWriter escritor;
            escritor = new StreamWriter("archivo.txt",true);

            escritor.Write("hola");
            escritor.Close();

            StreamReader lector;
            lector = new StreamReader("archivo.txt");*/
        }
    }
}
