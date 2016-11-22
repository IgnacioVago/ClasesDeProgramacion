using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Deportivo : Auto, IAfip
    {
        float impuesto;
        
        #region Constructores

        public Deportivo(string patente) : base(patente)
        { 
            
        }

        #endregion

        public float Impuesto
        {
            set { this.impuesto = value; }
            get { return this.impuesto; }
        }

        public float Impuesto2
        {
            set { this.impuesto = value; }
            get { return this.impuesto; }
        }

        #region Metodos

        public override float CalcularCosto()
        {
            return 150F;
        }

        public float RetornarImpuesto()
        {
            return 15F;
        }

        #endregion

        public virtual float impuesto1212
        {
            get;
            set;
        }





        
    }
}
