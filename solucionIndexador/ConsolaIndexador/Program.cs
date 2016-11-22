using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_de_clases;

namespace ConsolaIndexador
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pcUno;
            pcUno = "Samsung";
            PC pcDos;
            pcDos = "Toshiba";
            PC pcTres;
            pcTres = "Exo";
            
            Laboratorio laboratorioI;
            laboratorioI = new Laboratorio("2º A");

            laboratorioI[0] = pcUno; //ACTUAN COMO SI FUERAN PC
            laboratorioI[1] = pcDos; //ACTUAN COMO SI FUERAN PC
            laboratorioI[2] = pcTres; //ACTUAN COMO SI FUERAN PC

            Console.WriteLine(laboratorioI.ToString());

            for (int indiceIndexador = 0; indiceIndexador < laboratorioI.listaDePC.Count; indiceIndexador++)
            {
                Console.WriteLine(laboratorioI[indiceIndexador].ToString());
            }

            Console.ReadLine();
        }
    }
}
