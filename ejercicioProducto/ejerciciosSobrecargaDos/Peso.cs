using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSobrecargaDos
{
    public class Peso
    {
        public double cantidad;

        private Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Peso operator +(Peso valorUno, Dolar valorDos)
        {
            valorUno.cantidad = valorUno.cantidad + valorDos.cantidad;

            return valorUno;
        }

        public static implicit operator Peso(Dolar valor)
        {
            return new Peso(valor.cantidad * 15);
        }

        public static explicit operator Peso(double valor)
        {
            return new Peso(valor);
        }

    }
}
