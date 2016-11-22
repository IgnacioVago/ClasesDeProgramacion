using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionArrays
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public Alumno()
        {

        }

        public static bool operator ==(Alumno alumnoUno, Alumno alumnoDos)
        {
            if (alumnoUno.legajo == alumnoDos.legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno alumnoUno, Alumno alumnoDos)
        {
            if (alumnoUno.legajo != alumnoDos.legajo)
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
