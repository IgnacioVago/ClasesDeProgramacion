using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionHerencia
{
    public class Documento
    {
        public int numero;
        public string _fecha;
        public int _numeroDeControl;

        public Documento(int numero)
        {
            this.numero = numero;    
        }

        public Documento(int numero, string fecha, int numeroDeControl) : this(numero)
        {
            this._fecha = fecha;
            this._numeroDeControl = numeroDeControl;
        }

        public void mostrar()
        {
            Console.WriteLine("-Numero: " + this.numero);
            Console.WriteLine("-Fecha: " + this._fecha);
            Console.WriteLine("-Numero de Control: " + this._numeroDeControl);
        }
    }
}
