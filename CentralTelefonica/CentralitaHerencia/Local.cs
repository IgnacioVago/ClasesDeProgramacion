using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        #region Constructores

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        { 
            
        }

        #endregion 

        #region Metodos

        private float calcularCosto()
        {
            float costoLlamada;

            costoLlamada = _costo * base._duracion;

            return costoLlamada;
        }

        public void mostrarLocal()
        {
            StringBuilder sbLlamada;
            sbLlamada = new StringBuilder();

            sbLlamada.AppendLine("Duracion: " + base._duracion);
            sbLlamada.AppendLine("Destino: " + base._nroDestino);
            sbLlamada.AppendLine("Origen: " + base._nroOrigen);
            sbLlamada.AppendLine("Costo de llamada: " + this._costo);

            Console.WriteLine(sbLlamada);
        }

        #endregion

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.calcularCosto();
            }
        }

        #endregion
    }
}
