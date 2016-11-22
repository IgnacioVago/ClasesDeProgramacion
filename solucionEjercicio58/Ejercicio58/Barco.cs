using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio58
{
    [XmlInclude(typeof(Barco))]
    [Serializable]
    public abstract class Barco
    {
        public int _cantMaxPasajeros;
        public bool _motorEncendido;
        public string _destino;

        public Barco(int cantidadPasajeros, bool motorEncendido, string destino)
        {
            this._destino = destino;
            this._cantMaxPasajeros = cantidadPasajeros;
            this._motorEncendido = motorEncendido;
        }

        public Barco()
        {
            
        }

        public abstract List<Pasajero> Pasajeros
        {
            get;
        }

        public void Ingresar(Pasajero unPasajero)
        {
            if (this.Pasajeros.Count < this._cantMaxPasajeros)
            {
                this.Pasajeros.Add(unPasajero);
            }
            else
            {
                if (this is Transatlantico)
                {
                    throw new PasajerosOverFlowException("Barco transatlantico"+" "+DateTime.Now.ToString());
                }
                else
                {
                    throw new PasajerosOverFlowException("Barco crucero"+" "+DateTime.Now.ToString());
                }
            }
        }

        public virtual string IndicarDestino()
        {
            return this._destino;
        }

        public override string ToString()
        {
            StringBuilder sbBarco;
            sbBarco = new StringBuilder();

            sbBarco.AppendLine("---BARCO---");
            sbBarco.AppendLine("Cantidad de pasajeros: " + this._cantMaxPasajeros);
            sbBarco.AppendLine("Motor encendido: " + this._motorEncendido);
            sbBarco.AppendLine("Destino: " + this._destino);

            return sbBarco.ToString();
        }

        public bool EncenderMotor()
        {
            if (this._motorEncendido == true)
            {
                return this._motorEncendido;
            }
            else
            {
                this._motorEncendido = true;
            }

            return this._motorEncendido;
        }

        public int CantidadPersonas
        {
            get
            {
                return this._cantMaxPasajeros;
            }
        }

        public bool MotorEncendido
        {
            get
            {
                return this._motorEncendido;
            }
        }

        public string Destino
        {
            get
            {
                return this._destino;
            }
        }

    }
}
