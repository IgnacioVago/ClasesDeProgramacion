using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralitaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita miCentralita = new Centralita("Telefonica");
            //miCentralita.DeSerializarse();
            miCentralita.RutaDeArchivo = "Centralita.xml";

            Local LlamadaUno = new Local("Juan Martin", 0.3F, "Mama", 2.65F);
            Provincial LlamadaDos = new Provincial("Martin", Franja.Franja_1, 0.21F, "Abuela");
            Local LlamadaTres = new Local("Carlos", 0.45F, "Ezequiel", 1.99F);
            Provincial LlamadaCuatro = new Provincial(Franja.Franja_3, LlamadaDos);

            bool flag = false;

            try
            {
                miCentralita += LlamadaUno;
                miCentralita += LlamadaDos;
                miCentralita += LlamadaTres;
                miCentralita += LlamadaCuatro;
            }
            catch (CentralitaException x)
            {
                Console.WriteLine(x.NombreClase);
                Console.WriteLine(x.NombreMetodo);
                Console.WriteLine(x.Message);
                if (x.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + x.InnerException);
                }
            }

            Console.WriteLine(LlamadaUno.ToString());
            Console.WriteLine(LlamadaDos.ToString());
            Console.WriteLine(LlamadaTres.ToString());
            Console.WriteLine(LlamadaCuatro.ToString());

            Console.ReadLine();

            Console.Clear();

            miCentralita.ordenarLlamadas();

            Console.WriteLine("CENTRALITA ORDENADA");

            Console.WriteLine(miCentralita.ToString());

            Console.ReadLine();

            try
            {
                miCentralita.Serializarse();
            }
            catch (CentralitaException x)
            {
                Console.WriteLine(x.Message);
                Console.WriteLine(x.NombreClase);
                Console.WriteLine(x.NombreMetodo);

                if (x.ExcepcionInterna != null)
                {
                    Console.WriteLine(x.ExcepcionInterna);
                }
            }
            
            try
            {
                flag = miCentralita.DeSerializarse();

                if (flag == true)
                {
                    Console.WriteLine("Centralita deserializada");
                }
                else
                {
                    Console.WriteLine("Centralita no deserializada");
                }
            }
            catch (CentralitaException x)
            {
                Console.WriteLine(x.Message);
                Console.WriteLine(x.NombreClase);
                Console.WriteLine(x.NombreMetodo);

                if (x.ExcepcionInterna != null)
                {
                    Console.WriteLine(x.ExcepcionInterna);
                }
            }

            Console.ReadLine();
        }
    }
}
