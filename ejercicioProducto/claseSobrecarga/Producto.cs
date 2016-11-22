using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseSobrecarga
{
    public class Producto
    {
        private int _cantidad;

        private Producto(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static implicit operator Producto(int prodaux)
        {
            return new Producto(prodaux);
        }

        public static int operator +(Producto prodUno, Producto prodDos)
        {
            prodUno._cantidad = prodUno._cantidad + prodDos._cantidad;

            return prodUno._cantidad;
        }

    }
}
