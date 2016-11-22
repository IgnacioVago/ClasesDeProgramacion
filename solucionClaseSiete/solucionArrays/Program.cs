using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula miPrimerAula;
            miPrimerAula = new Aula();
            //Aula.mostrarAlumno(miPrimerAula);
            //bool existe;

            Alumno alumnoUno;
            alumnoUno = new Alumno("Pollo", 1);
            Alumno alumnoDos;
            alumnoDos = new Alumno("Rotela", 2);
            Alumno alumnoTres;
            alumnoTres = new Alumno("Ortiz", 3);
            Alumno alumnoCuatro;
            alumnoCuatro = new Alumno("Otero", 4);

            /*miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);
            miPrimerAula.borrarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno4);
            miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);*/
            miPrimerAula = miPrimerAula + alumnoUno;
            //miPrimerAula.listaDeAlumno[0].nombre="lalala";
            //existe = miPrimerAula.existeAlumno(alumnoDos);
            Aula.mostrarAlumno(miPrimerAula);
            //Console.WriteLine(existe);
            Console.ReadKey();
        }
    }
}
