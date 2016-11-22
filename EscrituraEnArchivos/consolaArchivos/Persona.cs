using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaArchivos
{
    public class Persona
    {
        private string _nombre;
        private string _clave;

        #region Constructores

        public Persona(string nombre, string clave)
        {
            this._nombre = nombre;
            this._clave = clave;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sbPersona;
            sbPersona = new StringBuilder();

            sbPersona.AppendLine(this._nombre+"," + this._clave);

            return sbPersona.ToString();
        }

        #endregion
    }
}
