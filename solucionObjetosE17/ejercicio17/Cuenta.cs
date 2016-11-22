using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    public class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoIntereses _tipoIntereses;

        public string getNombre()
        {
            return this._nombre;
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public ETipoIntereses getTipoInteres()
        {
            return this._tipoIntereses;
        }

        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void setNroCuenta(long nroCuenta)
        {
            this._nroCuenta = nroCuenta;
        }

        public void setSaldo(double saldo)
        {
            this._saldo = saldo;
        }

        public void setTipoInteres(ETipoIntereses tipoInteres)
        {
            this._tipoIntereses = tipoInteres;
        }
    }
}
