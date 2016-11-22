using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio58
{
    [XmlInclude(typeof(Barco))]
    [XmlInclude(typeof(Transatlantico))]
    public class Transatlantico : Barco, IServicioComedor
    {
        protected List<Pasajero> _pasajeros;

        public Transatlantico()
        { 
            
        }

        public Transatlantico(int cantidadPasajeros, bool motorEncendido, string destino) : base(cantidadPasajeros, motorEncendido, destino)
        {
            this._pasajeros = new List<Pasajero>();
        }

        public void ServirComida(string comidaAServir)
        {
            Console.WriteLine("Comida a servir: " + comidaAServir);
        }

        public override List<Pasajero> Pasajeros
        {
            get 
            {
                return this._pasajeros;
            }
        }

        public override string ToString()
        {
            StringBuilder sbTransatlantico;
            sbTransatlantico = new StringBuilder();

            sbTransatlantico.AppendLine("---TRANSATLANTICO---");
            sbTransatlantico.AppendLine(base.ToString());

            foreach (Pasajero item in this._pasajeros)
            {
                sbTransatlantico.AppendLine(item.ToString());
            }

            return sbTransatlantico.ToString();
        }
    }
}
