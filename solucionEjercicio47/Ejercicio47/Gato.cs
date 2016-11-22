using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio47
{
    [Serializable]
    public class Gato : Animal, Mascota
    {
        private string _nombre;

        public Gato()
        { 
            
        }

        public Gato(int cantidadPatas, string nombre) : base(cantidadPatas)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Comida para gatos");
        }

        public void Jugar()
        {
            Console.WriteLine("Gato jugando");
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
    }
}
