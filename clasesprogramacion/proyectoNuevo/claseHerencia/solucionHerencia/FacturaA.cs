using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionHerencia
{
    public class FacturaA : Factura
    {
        public int iva;

        public FacturaA(int iva, Factura miFactura) : base(miFactura.numero, miFactura._fecha, miFactura._numeroDeControl)
        {
            this.iva = iva;
        }
    }
}
