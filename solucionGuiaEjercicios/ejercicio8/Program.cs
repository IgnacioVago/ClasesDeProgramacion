using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";

            /* Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años)
             * y la cantidad de horas trabajadas en el mes de n empleados de una fábrica. 
             * Se pide calcular el importe a cobrar teniendo en cuenta que el total 
             * (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
             * hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
             * y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 
             * 
             * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
             * el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.  
              Nota: Utilizar estructuras repetitivas y selectivas
             * */

            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            int importeCobrar;
            int cobroBruto;
            int descuentos;
            int valorNeto;

            Console.Write("\nIngrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("\nIngrese valor de hora: ");
            valorHora = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese antigüedad en años: ");
            antiguedad = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese horas trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            importeCobrar = (valorHora * horasTrabajadas) + (antiguedad*150);
            descuentos = (importeCobrar * 13) / 100;
            cobroBruto = importeCobrar;
            valorNeto = importeCobrar - descuentos;

            Console.Write("\nNombre: "+nombre);
            Console.Write("\nAntiguedad: "+antiguedad+" años");
            Console.Write("\nValor por hora: "+valorHora);
            Console.Write("\nCobro en bruto: "+cobroBruto);
            Console.Write("\nDescuentos: "+descuentos);
            Console.Write("\nCobro en neto: "+valorNeto);
            Console.ReadKey();

        }
    }
}
