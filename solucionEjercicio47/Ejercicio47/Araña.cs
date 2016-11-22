using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio47
{
    [Serializable]
    public class Araña : Animal, Mascota
    {
        private string _nombre;

        public Araña()
        {
        
        }

        public Araña(int cantidadPatas, string nombre) : base(cantidadPatas)
        {
            this._nombre = nombre;
        }

        public void Jugar()
        {
            Console.WriteLine("Araña jugando");
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
            Console.WriteLine("Araña comiendo");
        }
    }
}
