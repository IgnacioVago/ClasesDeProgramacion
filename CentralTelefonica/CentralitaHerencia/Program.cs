using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita miCentralita;
            miCentralita = new Centralita("Telefonica");
            Local llamadaLocalUno;
            llamadaLocalUno = new Local("Juan Martin", 0.30F, "Abuela", 2.65F);
            Provincial llamadaProvincialUno;
            llamadaProvincialUno = new Provincial("Cristian", Franja.Franja_1, 0.21F, "Trabajo");
            Local llamadaLocalDos;
            llamadaLocalDos = new Local("Mariana", 0.45F, "Hermana", 1.99F);
            Provincial llamadaProvincialDos;
            llamadaProvincialDos = new Provincial(Franja.Franja_2, llamadaProvincialUno);

            miCentralita.Llamadas.Add(llamadaLocalUno);
            miCentralita.Llamadas.Add(llamadaLocalDos);
            miCentralita.Llamadas.Add(llamadaProvincialUno);
            miCentralita.Llamadas.Add(llamadaProvincialDos);
            llamadaLocalUno.mostrarLocal();
            llamadaProvincialUno.mostrarProvincial();
            Console.WriteLine("***********************************************\n");
            miCentralita.ordenarLlamadas();
            miCentralita.mostrarCentralita();
            //llamadaLocalUno.mostrarLocal();
            //llamadaLocalDos.mostrarLocal();
            //llamadaProvincialUno.mostrarProvincial();
            //llamadaProvincialDos.mostrarProvincial();
            Console.ReadLine();
        }
    }
}
