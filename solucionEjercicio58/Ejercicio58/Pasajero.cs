using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio58
{
    [XmlInclude(typeof(Pasajero))]
    public class Pasajero
    {
        public string _apellido;
        public string _nombre;
        public ERangos _rango;

        public enum ERangos
        {
            Camarero,
            Cocinero,
            Capitan,
            Cliente
        }

        public Pasajero()
        { 
            
        }

        public Pasajero(string apellido, string nombre, ERangos rango)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._rango = rango;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Apellido: " + this._apellido);
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Rango: " + this._rango);

            return sb.ToString();
        }
    }
}
