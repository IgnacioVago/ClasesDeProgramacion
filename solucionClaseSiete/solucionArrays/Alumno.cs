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

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            if (alumno1.legajo == alumno2.legajo)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            if (alumno1.legajo != alumno2.legajo)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public bool Equals(Alumno alumno, Aula aula)
        {
            if ((object)alumno == (object)aula)
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
