using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Constructores

        public Llamada(string numeroOrigen, string numeroDestino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = numeroDestino;
            this._nroOrigen = numeroOrigen;
        }

        #endregion

        #region Metodos

        public void mostrarLlamada()
        {
            StringBuilder sbLlamada;
            sbLlamada = new StringBuilder();

            sbLlamada.AppendLine("Duracion: " + this._duracion);
            sbLlamada.AppendLine("Destino: " + this._nroDestino);
            sbLlamada.AppendLine("Origen: " + this._nroOrigen);

            Console.WriteLine(sbLlamada);
        }

        public static int ordenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            return String.Compare(llamadaUno._duracion.ToString(), llamadaDos._duracion.ToString());
        }

        #endregion

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        #endregion
    }
}
