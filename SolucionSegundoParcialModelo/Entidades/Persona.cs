using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Empleado))]
    [Serializable]
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        public Persona()
        { 
            
        }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string ToString()
        {
            StringBuilder sbPersona;
            sbPersona = new StringBuilder();

            sbPersona.AppendLine("Nombre: " + this._nombre);
            sbPersona.AppendLine("Apellido: " + this._apellido);
            sbPersona.AppendLine("Legajo: " + this.Legajo);
            sbPersona.AppendLine("----------------------------");

            return sbPersona.ToString();
        }

        protected abstract int Legajo
        {
            get;
            set;
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

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

    }
}
