using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            alumnoUno.nombre = "Juan Martin";
            alumnoUno.apellido = "Pollio";

            alumnoDos.nombre = "Cristian";
            alumnoDos.apellido = "Pollio";

            alumnoTres.nombre = "Mariana";
            alumnoTres.apellido = "Santesso";

            alumnoUno.legajo = 1998;
            alumnoDos.legajo = 1975;
            alumnoTres.legajo = 1978;

            alumnoUno.Estudiar(10,8);
            alumnoDos.Estudiar(6, 4);
            alumnoTres.Estudiar(1, 2);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            alumnoUno.Mostrar();
            alumnoDos.Mostrar();
            alumnoTres.Mostrar();

            Console.ReadKey();
        }
    }
}
