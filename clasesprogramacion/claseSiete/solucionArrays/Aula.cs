using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionArrays
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumnos;

        public Aula()
        {
            this.listaDeAlumnos = new Alumno[10];

            /*for (int contadorAlumnos = 0; contadorAlumnos < 10; contadorAlumnos++)
            {
                this.listaDeAlumnos[contadorAlumnos] = new Alumno();
            }

            foreach (Alumno objAlumno in this.listaDeAlumnos)
            {
                objAlumno.nombre = "Natalia Natalia";
            }*/
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Devuelve el indice del primer elemento null, de lo contrario, retorna -1</returns>

        public int obtenerIndice()
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if ((object)this.listaDeAlumnos[contadorAlumno] == null)
                {
                    break;
                }
            }

            if (contadorAlumno<10)
            {
                return contadorAlumno;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unAlumno"></param>
        /// <returns>Retorna el indice del objeto, de lo contrario, retorna -1</returns>

        public int obtenerIndice(Alumno unAlumno)
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if ((object)this.listaDeAlumnos[contadorAlumno] == unAlumno)
                {
                    return this.listaDeAlumnos[contadorAlumno].legajo;
                }
            }

                return -1;
        }

        public void agregarAlumno(Alumno unAlumno)
        {
            int indice;
            indice = obtenerIndice();
            int indiceDos;
            indiceDos = obtenerIndice(unAlumno);

            //if (existeAlumno(unAlumno) == false)
            //{
                if (indice != -1 && indiceDos == -1)
                {
                    this.listaDeAlumnos[indice] = unAlumno;
                }
                else
                {
                    if (indiceDos != -1)
                    {
                        Console.WriteLine("El alumno ingresado ya existe");
                    }
                    else
                    {
                        Console.WriteLine("No queda mas espacio en el array");
                    }
                }
            //}
            //else
            //{
               // Console.WriteLine("El alumno ingresado ya existe");
            //}
        }

        public void borrarAlumno(Alumno unAlumno)
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if ((object)this.listaDeAlumnos[contadorAlumno] != null && this.listaDeAlumnos[contadorAlumno] == unAlumno)
                {
                    this.listaDeAlumnos[contadorAlumno] = null;
                }
            }
        }

        public bool existeAlumno(Alumno unAlumno)
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
			{
                if ((object)this.listaDeAlumnos[contadorAlumno] != null && this.listaDeAlumnos[contadorAlumno].legajo == unAlumno.legajo)
                {
                    return true;
                }
			}

            return false;
        }

        public static void mostrarAlumno(Aula aula)
        {
            foreach (Alumno objAlumno in aula.listaDeAlumnos)
            {
                if ((object)objAlumno != null)
                {
                    Console.WriteLine("Nombre: " + objAlumno.nombre);
                    Console.WriteLine("Legajo: " + objAlumno.legajo);
                }
                else
                {
                    Console.WriteLine("El objeto se encuentra en null");
                }
            }
            Console.ReadLine();
        }
    }
}
