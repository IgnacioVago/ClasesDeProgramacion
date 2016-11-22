using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio58
{
    [XmlInclude(typeof(Crucero))]
    public class Crucero : Barco
    {
        public List<Pasajero> _pasajeros;

        public Crucero()
        { 
            
        }

        public Crucero(int cantidadPasajeros, bool motorEncendido, string destino) : base(cantidadPasajeros, motorEncendido, destino)
        {
            this._pasajeros = new List<Pasajero>();
        }

        public override List<Pasajero> Pasajeros
        {
            get
            {
                return this._pasajeros;
            }
        }
    }
}
