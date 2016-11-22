using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSobrecargaDos
{
    public class Dolar
    {
        public double cantidad;

        private Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Dolar operator +(Dolar valorUno, Peso valorDos)
        {
            valorUno.cantidad = valorUno.cantidad + valorDos.cantidad;

            return valorUno;
        }

        public static implicit operator Dolar(Peso valor)
        {
            return new Dolar(valor.cantidad / 15);
        }

        public static implicit operator Dolar(double valor)
        {
            return new Dolar(valor);
        }
    }
}
