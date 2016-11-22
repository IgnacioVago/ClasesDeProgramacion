using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Familiar : Auto
    {

        #region Constructores
        
        public Familiar(string patente) : base(patente)
        { 
            
        }

        #endregion

        #region Metodos

        public override float CalcularCosto()
        {
            return 100F;
        }

        #endregion
    }
}
