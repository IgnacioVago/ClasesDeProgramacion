using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aula miPrimerAula;
            miPrimerAula = new Aula();

            Alumno alumnoUno;
            alumnoUno = new Alumno();

            alumnoUno.nombre = "Carlos";
            alumnoUno.legajo = 123456;

            Alumno alumnoDos;
            alumnoDos = new Alumno();

            alumnoDos.nombre = "Carlos";
            alumnoDos.legajo = 123456;

            Alumno alumnoTres;
            alumnoTres = new Alumno();

            alumnoTres.nombre = "Cristian";
            alumnoTres.legajo = 123456;

            Alumno alumnoCuatro;
            alumnoCuatro = new Alumno();

            alumnoCuatro.nombre = "Esteban";
            alumnoCuatro.legajo = 123456;

            miPrimerAula.agregarAlumno(alumnoUno);
            //Aula.mostrarAlumno(miPrimerAula);
            //Console.ReadKey();

            //miPrimerAula.borrarAlumno(alumnoUno);
            miPrimerAula.agregarAlumno(alumnoDos);
            //miPrimerAula.agregarAlumno(alumnoTres);
            //miPrimerAula.agregarAlumno(alumnoCuatro);

            if (alumnoUno == alumnoDos)
            {
                Console.WriteLine("Son iguales");
            }

            //Aula.mostrarAlumno(miPrimerAula);

            Console.ReadKey();

            //miPrimerAula.agregarAlumno(alumnoUno);
            //miPrimerAula.agregarAlumno(alumnoDos);
            //miPrimerAula.agregarAlumno(alumnoTres);
            //miPrimerAula.agregarAlumno(alumnoCuatro);


            Aula.mostrarAlumno(miPrimerAula);
        }
    }
}
