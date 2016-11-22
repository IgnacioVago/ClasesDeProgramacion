using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Privada : Avion, IAfip
    {
        #region Constructor

        public Privada(string patente) : base(patente)
        { 
            
        }

        #endregion

        public virtual float impuesto112
        {
            get;
            set;
        }
    }
}
