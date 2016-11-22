using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public abstract class Auto : Vehiculo
    {
        public int cantidadPuertas;

        #region Constructores

        public Auto(string patente) : base(patente)
        { 
            
        }

        #endregion

        #region Metodos

        public override string MostrarDatos()
        {
            StringBuilder sbAuto = new StringBuilder();

            sbAuto.Append(base.MostrarDatos());
            sbAuto.AppendLine("-Auto-");
            sbAuto.AppendLine("Cantidad de puertas: " + this.cantidadPuertas.ToString());

            return sbAuto.ToString();
        }

        #endregion
    }
}
