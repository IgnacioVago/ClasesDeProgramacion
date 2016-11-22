using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Carreta : Vehiculo
    {


        #region Constructores
        
        public Carreta(string patente) : base(patente)
        {
            
        }

        #endregion

        #region Metodos

        public override float CalcularCosto()
        {
            return 5F;
        }

        #endregion
        
    }
}
