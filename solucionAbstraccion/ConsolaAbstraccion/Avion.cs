using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Avion : Vehiculo, IAfip
    {
        public int cantidadDePuertas;

        #region Constructores

        public Avion(string patente) : base(patente)
        { 
            
        }

        #endregion

        #region Metodos

        public override float CalcularCosto()
        {
            return 1500F;
        }

        public float RetornarImpuesto()
        {
            return 150F;
        }

        #endregion





        
    }
}
