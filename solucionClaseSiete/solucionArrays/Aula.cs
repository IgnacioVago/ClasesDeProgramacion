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
        public Alumno[] listadoDeAlumno;

        public Aula()
        {
            this.listadoDeAlumno = new Alumno[10];
            /*for (int contadorDeAlumnos = 0; contadorDeAlumnos < 10; contadorDeAlumnos++)
            {
                this.listaDeAlumno[contadorDeAlumnos] = new Alumno();
            }
            No hacer nunca asi.
            foreach (Alumno objAlum in this.listaDeAlumno)
            {
                objAlum.nombre = "Natalia Natalia";
            }*/
        }

        public static void mostrarAlumno(Aula aula)
        {
            foreach (Alumno objAlumno in aula.listadoDeAlumno)
            {
                if (objAlumno != null)
                {
                    Console.WriteLine("nombre: " + objAlumno.nombre + " legajo: " + objAlumno.legajo);
                }
            }
        }

        /// <summary>
        /// devuelve el indice del primer elemento null de la contrario return -1
        /// </summary>
        /// <returns></returns>

        public int obtenerIndice()
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if (this.listadoDeAlumno[contadorAlumno] == null)
                {
                    break;
                }
            }

            if (contadorAlumno < 10)
            {
                return contadorAlumno;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// retorna el indice del objeto, de lo contrario retorna -1.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>

        public int obtenerIndice(Alumno alumno)
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if (this.listadoDeAlumno[contadorAlumno] != null && this.listadoDeAlumno[contadorAlumno] == alumno)
                {
                    return this.listadoDeAlumno[contadorAlumno].legajo;
                }
            }

            return -1;
        }

        public void agregarAlumno(Alumno alumno)
        {
            int indice;
            indice = this.obtenerIndice();
            int indiceDos;
            indiceDos = this.obtenerIndice(alumno);

            if (indice != -1 && indiceDos == -1)
            {
                this.listadoDeAlumno[indice] = alumno;
            }
            else
            {
                if (indice == -1)
                {
                    Console.WriteLine("Ya existe");
                }
                else
                {
                    Console.WriteLine("Array lleno");
                }
            }
        }

        public void borrarAlumno(Alumno alumno)
        {
            int contadorAlumno;

            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if (this.listadoDeAlumno[contadorAlumno] != null && this.listadoDeAlumno[contadorAlumno].legajo == alumno.legajo)
                {
                    this.listadoDeAlumno[contadorAlumno] = null;
                    break;
                }
            }
        }

        public bool existeAlumno(Alumno alumno)
        {
            int contadorAlumno;


            for (contadorAlumno = 0; contadorAlumno < 10; contadorAlumno++)
            {
                if (this.listadoDeAlumno[contadorAlumno] != null && this.listadoDeAlumno[contadorAlumno].legajo == alumno.legajo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Aula aula, Alumno alumno)
        {
            /*if (aula == alumno)
                return true;
            return false;*/
            return aula.existeAlumno(alumno);
        }

        public static bool operator !=(Aula aula, Alumno alumno)
        {
            return !(aula.existeAlumno(alumno));
        }

        public static Aula operator +(Aula aula, Alumno alumno)
        {
            aula.agregarAlumno(alumno);
            return aula;
        }

        public static Aula operator -(Aula aula, Alumno alumno)
        {
            aula.borrarAlumno(alumno);
            return aula;
        }
    }
}
