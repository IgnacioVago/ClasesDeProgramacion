using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolaSerializacion
{
    public class Aula
    {
        public int numero;
        private List<Persona> listaDeAlumnos;
        public Persona profesor;
        private string _nombreDelAula;

        public Aula()
        { 
            
        }

        public Aula(int numero, string nombreDelAula, Persona profesor, List<Persona> listaDePersonas) : this()
        {
            this._nombreDelAula = nombreDelAula;
            this.numero = numero;
            this.listaDeAlumnos = listaDePersonas;
            this.profesor = profesor;
        }

        public string NombreDelAula
        {
            set
            {
                this._nombreDelAula = value;
            }
            get
            {
                return this._nombreDelAula;
            }
        }


        public List<Persona> listadoDeAlumnos
        {
            get
            {
                return this.listaDeAlumnos;
            }
        }
    }
}
