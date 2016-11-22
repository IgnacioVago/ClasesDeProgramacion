using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public abstract class Vehiculo
    {
        public string patente;

        #region Constructor
        
        public Vehiculo(string patente)
        {
            this.patente = patente;           
        }

        #endregion

        #region Metodos virtuales

        public override string ToString()
        {
            return this.patente;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sbVehiculo = new StringBuilder();

            sbVehiculo.AppendLine("Vehiculo:");
            sbVehiculo.AppendLine("Patente: "+this.patente);

            return sbVehiculo.ToString();       
        }

        public abstract float CalcularCosto();

        #endregion
    }
}
