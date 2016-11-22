using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio47
{
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Araña))]
    [XmlInclude(typeof(Pez))]
    [Serializable]
    public abstract class Animal
    {
        protected int _patas;

        public Animal()
        {
                
        }

        public Animal(int cantidadPatas)
        {
            this._patas = cantidadPatas;
        }

        public virtual void Caminar()
        {
            Console.WriteLine("Este animal camina en " + this._patas + " patas");
        }

        public abstract void Comer();

        public int CantidadPatas
        {
            get
            {
                return this._patas;
            }
            set
            {
                this._patas = value;
            }
        }
    }
}
