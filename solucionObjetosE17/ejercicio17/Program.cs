using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta;
            cuenta = new Cuenta();

            cuenta.setNombre("Juan Martin");
            cuenta.setSaldo(30000);
            cuenta.setNroCuenta(1998);
            cuenta.setTipoInteres(ETipoIntereses.TIN);

            Console.Write("\nNombre: " + cuenta.getNombre());
            Console.Write("\nSaldo: " + cuenta.getSaldo());
            Console.Write("\nNumero de cuenta: " + cuenta.getNroCuenta());
            Console.Write("\nInteres de la cuenta: " + cuenta.getTipoInteres());
            Console.ReadKey();
        }
    }
}
