using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class Alumno
    {
        public string nombre;
        public int nota;

        public void MostrarDatos()
        {
            Console.WriteLine(this.nombre);
            Console.WriteLine(this.nota);
            Console.ReadKey();
        }

        public static bool CompararAlumnos(Alumno uno, Alumno dos)
        {
            if (uno.nombre == dos.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compararme(Alumno otro)
        {
            if(this.nombre == otro.nombre)
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
