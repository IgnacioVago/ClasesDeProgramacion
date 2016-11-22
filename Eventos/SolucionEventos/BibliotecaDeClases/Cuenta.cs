using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void CuentaDelegado(float dinero);

    public class Cuenta
    {
        public float saldo;

        public void SacarDinero(float dinero)
        {
            if (dinero > this.saldo)
            {
                //si estuvieramos en una aplicacion de consola Console.WriteLine
                //si estuvieramos en una aplicacion de windows form MessageBox.Show
                //si estuvieramos en una pagina web seria un alert
                SaldoNegativo(this.saldo - dinero);
            }
        }

        public event CuentaDelegado SaldoNegativo;
    }
}
