using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factura miFactura;
            miFactura = new Factura(666,"14/09/2016",1234);
            FacturaA miFacturaA;
            miFacturaA = new FacturaA(21, miFactura);
            FacturaAPagada miFacturaAPagada;
            miFacturaAPagada = new FacturaAPagada("hoy", miFacturaA);
            Remito miRemito;
            miRemito = new Remito(999,"15/09/2016",1234);

            List<Documento> miListado;
            miListado = new List<Documento>();

            miListado.Add(miFactura);
            miListado.Add(miRemito);
            miListado.Add(miFacturaA);
            miListado.Add(miFacturaAPagada);

            foreach (Documento item in miListado)
            {
                item.mostrar();
            }

            Console.ReadLine();
        }
    }
}
