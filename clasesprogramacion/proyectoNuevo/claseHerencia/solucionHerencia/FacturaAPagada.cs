using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionHerencia
{
    public class FacturaAPagada : FacturaA
    {
        public string fechaDePago;

        public FacturaAPagada(string fechaDePago, FacturaA miFacturaA) : base(miFacturaA.iva, miFacturaA)
        {
            this.fechaDePago = fechaDePago;
        }
    }
}
