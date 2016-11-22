using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public delegate void PersonaDelegado(string nombre);

    public class Persona
    {
        public string nombre;

        public Persona()
        {
            this.nombreDeLaPersona += new PersonaDelegado(this.MostrarNombreDeLaPersona);
        }

        public event PersonaDelegado nombreDeLaPersona;

        public void MostrarNombre(string nombre)
        {
            nombreDeLaPersona(nombre);
        }

        public void MostrarNombreDeLaPersona(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine("Nombre: " + this.nombre);
        }
    }
}
