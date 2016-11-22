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
            valorUno.cantidad = valorUno.cantidad + (valorDos.cantidad/15);

            return valorUno;
        }

        public static implicit operator double(Dolar valor)
        {
            return valor.cantidad;
        }

        public static implicit operator Dolar(Peso valor)
        {
            valor.cantidad = valor.cantidad / 15;

            return new Dolar(valor.cantidad);
        }

        public static implicit operator Dolar(double valor)
        {
            return new Dolar(valor);
        }
    }
}
