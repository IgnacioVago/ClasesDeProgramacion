using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Comercial : Avion, IAfip
    {
        #region Constructor

        public Comercial(string patente) : base(patente)
        { 
            
        }

        #endregion

        #region Metodos
        
        /*float IAfip.RetornarImpuesto()
        {
            return base.RetornarImpuesto();
        }*/
  
        #endregion

    }
}
