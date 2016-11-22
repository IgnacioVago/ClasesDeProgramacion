using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vehiculo vehiculoUno;
            vehiculoUno = new Vehiculo("ABC123");*/

            //Auto AutoUno = new Auto("GGG999");
            //AutoUno.cantidadPuertas = 6;

            //Console.WriteLine(vehiculoUno.MostrarDatos());
            //Console.WriteLine(AutoUno.MostrarDatos());

            Deportivo autoDeportivo;
            Carreta carretaUno;
            Comercial comercialUno;
            Familiar autoFamiliar;

            autoDeportivo = new Deportivo("AAA 000");
            carretaUno = new Carreta("AAA 001");
            comercialUno = new Comercial("AAA 002");
            autoFamiliar = new Familiar("AAA 003");

            List<Vehiculo> listaDeVehiculos;
            listaDeVehiculos = new List<Vehiculo>();

            listaDeVehiculos.Add(autoDeportivo);
            listaDeVehiculos.Add(carretaUno);
            listaDeVehiculos.Add(comercialUno);
            listaDeVehiculos.Add(autoFamiliar);

            foreach (Vehiculo item in listaDeVehiculos)
            {
                Console.WriteLine("Costo: " + item.CalcularCosto());
            }

            List<IAfip> listaDeImpuestos;
            listaDeImpuestos = new List<IAfip>();

            listaDeImpuestos.Add(autoDeportivo);
            listaDeImpuestos.Add(comercialUno);

            foreach (IAfip item in listaDeImpuestos)
            {
                //Console.WriteLine("Impuesto: " + item.RetornarImpuesto());
                Console.WriteLine("Impuesto: " + Gestion.MostrarImp(item));
            }

            Console.ReadLine();
        }
    }
}
