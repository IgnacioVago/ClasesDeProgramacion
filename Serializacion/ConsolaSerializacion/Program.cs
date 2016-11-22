using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona;
            unaPersona = new Persona("Pepe");

            Alumno unAlumno;
            unAlumno = new Alumno();
            unAlumno.nombre = "Esteban";
            unAlumno.legajo = 125;

            Serializador.SerializarPersona(unaPersona);

            List<Persona> listadoDePersonas;
            listadoDePersonas = new List<Persona>();

            listadoDePersonas.Add(new Persona("Carlos"));
            listadoDePersonas.Add(new Persona("Pepe"));
            listadoDePersonas.Add(unAlumno);

            Serializador.SerializarListadoDePersonas(listadoDePersonas);

            Aula miAula;
            miAula = new Aula(1,"Primero",new Persona("Octavio"), listadoDePersonas);

            Serializador.SerializarAula(miAula);

        }
    }
}
