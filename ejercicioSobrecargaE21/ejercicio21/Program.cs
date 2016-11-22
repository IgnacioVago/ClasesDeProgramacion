using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Construir dos clases: la clase Euro y la clase Dolar. 
             * Se debe lograr que los objetos de estas clases se puedan sumar, restar, comparar, incrementar y disminuir con total normalidad
             * como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1.3642 dólares. 
             * Además, tienen que ser compatibles entre sí y también con el tipo Double. 
             * Sobrecargar los operadores explicit y/o implicit.  
                Nota: Las clases y el Program deben estar en namespaces distintos. 
             */

            dolar.Dolar dolarUno;
            dolarUno = new dolar.Dolar(4);
            euro.Euro euroUno;
            euroUno = new euro.Euro(1);
            dolarUno = dolarUno + (dolar.Dolar)euroUno;

            Console.WriteLine("Cantidad de dolares: " + dolarUno._cantidad);

            dolar.Dolar dolarDos;
            dolarDos = new dolar.Dolar(5);
            euro.Euro euroDos;
            euroDos = new euro.Euro(3);
            euroDos = euroDos + (euro.Euro)dolarDos;

            Console.WriteLine("Cantidad de euros: " + euroDos._cantidad);
 
            Console.ReadLine();
        }
    }
}
