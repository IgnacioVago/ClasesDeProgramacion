using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio47
{
    [XmlInclude(typeof(Pez))]
    public class Pez : Animal, Mascota
    {
        private string _nombre;

        public Pez()
        { 
            
        }

        public Pez(int cantidadPatas, string nombre) : base(cantidadPatas)
        {
            this._nombre = nombre;
        }

        public void Jugar()
        {
            Console.WriteLine("Pez nadando");
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public override void Comer()
        {
            Console.WriteLine("Pez comiendo");
        }
    }
}
