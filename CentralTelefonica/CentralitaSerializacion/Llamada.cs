using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    [XmlInclude(typeof(Provincial))]
    [XmlInclude(typeof(Local))]
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Constructores

        public Llamada()
        { 
            
        }

        public Llamada(string numeroOrigen, string numeroDestino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = numeroDestino;
            this._nroOrigen = numeroOrigen;
        }

        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder sbLlamada;
            sbLlamada = new StringBuilder();

            sbLlamada.AppendLine("Duracion: " + this._duracion);
            sbLlamada.AppendLine("Destino: " + this._nroDestino);
            sbLlamada.AppendLine("Origen: " + this._nroOrigen);

            return sbLlamada.ToString();
        }

        public static int ordenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            return String.Compare(llamadaUno._duracion.ToString(), llamadaDos._duracion.ToString());
        }

        #endregion

        #region Propiedades

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
            set
            {
                this._duracion = value;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
            set
            {
                this._nroDestino = value;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
            set
            {
                this._nroOrigen = value;
            }
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            if (llamadaUno.Equals(llamadaDos) && llamadaDos.Equals(llamadaUno) && llamadaUno._nroOrigen == llamadaDos._nroOrigen && llamadaUno._nroDestino == llamadaDos._nroDestino)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

        #endregion
    }
}
