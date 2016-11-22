using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euro
{
    /*
                Construir dos clases: la clase Euro y la clase Dolar. 
             * Se debe lograr que los objetos de estas clases se puedan sumar, restar, comparar, incrementar y disminuir con total normalidad
             * como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1.3642 dólares. 
             * Además, tienen que ser compatibles entre sí y también con el tipo Double. 
             * Sobrecargar los operadores explicit y/o implicit.  
                Nota: Las clases y el Program deben estar en namespaces distintos. 
             */

    public class Euro
    {
        public double _cantidad;

        public Euro(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Euro operator +(Euro euroaux, double valor)
        {
            euroaux._cantidad = euroaux._cantidad + valor;

            return euroaux;
        }

        public static Euro operator +(Euro euroaux, Euro valor)
        {
            euroaux._cantidad = euroaux._cantidad + valor._cantidad;

            return euroaux;
        }

        public static Euro operator -(Euro euroaux, double valor)
        {
            euroaux._cantidad = euroaux._cantidad - valor;

            return euroaux;
        }

        public static Euro operator -(Euro euroaux, Euro valor)
        {
            euroaux._cantidad = euroaux._cantidad - valor._cantidad;

            return euroaux;
        }

        public static Euro operator ++(Euro euroaux)
        {
            euroaux._cantidad = euroaux._cantidad + 1;

            return euroaux;
        }

        public static Euro operator --(Euro euroaux)
        {
            euroaux._cantidad = euroaux._cantidad - 1;

            return euroaux;
        }

        public static bool operator ==(Euro euroaux, int valor)
        {
            if (euroaux._cantidad == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, int valor)
        {
            if (euroaux._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euroaux, Euro valor)
        {
            if (euroaux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, Euro valor)
        {
            if (euroaux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Euro operator +(Euro euroaux, dolar.Dolar valor)
        {
            euroaux._cantidad = euroaux._cantidad + valor._cantidad;

            return euroaux;
        }

        public static Euro operator -(Euro euroaux, dolar.Dolar valor)
        {
            euroaux._cantidad = euroaux._cantidad - valor._cantidad;

            return euroaux;
        }

        public static bool operator ==(Euro euroaux, dolar.Dolar valor)
        {
            if (euroaux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, dolar.Dolar valor)
        {
            if (euroaux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static implicit operator double(Euro valor)
        {
            return valor._cantidad;
        }

        public static implicit operator Euro(dolar.Dolar cantidad)
        {
            return new Euro(cantidad._cantidad / 1.3642);
        }
    }
}
