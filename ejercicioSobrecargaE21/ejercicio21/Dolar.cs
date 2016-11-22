using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolar
{
    /*
                Construir dos clases: la clase Euro y la clase Dolar. 
             * Se debe lograr que los objetos de estas clases se puedan sumar, restar, comparar, incrementar y disminuir con total normalidad
             * como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1.3642 dólares. 
             * Además, tienen que ser compatibles entre sí y también con el tipo Double. 
             * Sobrecargar los operadores explicit y/o implicit.  
                Nota: Las clases y el Program deben estar en namespaces distintos. 
             */

    public class Dolar
    {
        public double _cantidad;

        public Dolar(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Dolar operator +(Dolar dolaraux, double valor)
        {
            dolaraux._cantidad = dolaraux._cantidad + valor;

            return dolaraux;
        }

        public static Dolar operator +(Dolar dolaraux, Dolar valor)
        {
            dolaraux._cantidad = dolaraux._cantidad + valor._cantidad;

            return dolaraux;
        }

        public static Dolar operator -(Dolar dolaraux, double valor)
        {
            dolaraux._cantidad = dolaraux._cantidad - valor;

            return dolaraux;
        }

        public static Dolar operator -(Dolar dolaraux, Dolar valor)
        {
            dolaraux._cantidad = dolaraux._cantidad - valor._cantidad;

            return dolaraux;
        }

        public static Dolar operator ++(Dolar dolaraux)
        {
            dolaraux._cantidad = dolaraux._cantidad + 1;

            return dolaraux;
        }

        public static Dolar operator --(Dolar dolaraux)
        {
            dolaraux._cantidad = dolaraux._cantidad - 1;

            return dolaraux;
        }

        public static bool operator ==(Dolar dolaraux, int valor)
        {
            if (dolaraux._cantidad == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, int valor)
        {
            if (dolaraux._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolaraux, Dolar valor)
        {
            if (dolaraux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, Dolar valor)
        {
            if (dolaraux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Dolar operator +(Dolar dolaraux, euro.Euro valor)
        {
            dolaraux._cantidad = dolaraux._cantidad + valor._cantidad;

            return dolaraux;
        }

        public static Dolar operator -(Dolar dolaraux, euro.Euro valor)
        {
            dolaraux._cantidad = dolaraux._cantidad - valor._cantidad;

            return dolaraux;
        }

        public static bool operator ==(Dolar dolaraux, euro.Euro valor)
        {
            if (dolaraux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, euro.Euro valor)
        {
            if (dolaraux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static implicit operator double(Dolar valor)
        {
            return valor._cantidad;
        }

        public static implicit operator Dolar(euro.Euro valor)
        {
            return new Dolar(valor._cantidad * 1.3642);
        }
    }
}
