using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio47
{
    [XmlInclude(typeof(Animal))]
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Araña))]
    [XmlInclude(typeof(Pez))]
    [XmlInclude(typeof(List<Animal>))]
    class Program
    {
        static void Main(string[] args)
        {
            Pez pescadito;
            Gato gatito;
            Araña arañita;

            pescadito = new Pez(4, "Nemo");
            gatito = new Gato(4, "Macri");
            arañita = new Araña(4, "Davila");

            List<Animal> listaDeAnimales;
            listaDeAnimales = new List<Animal>();

            listaDeAnimales.Add(pescadito);
            listaDeAnimales.Add(gatito);
            listaDeAnimales.Add(arañita);

            Serializador<List<Animal>> xmlLista;
            xmlLista = new Serializador<List<Animal>>();

            if (xmlLista.serializar("animales.xml",listaDeAnimales))
            {
                Console.WriteLine("Animales serializados");
            }

            Console.ReadLine();
        }
    }
}
