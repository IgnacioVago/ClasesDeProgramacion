using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region Metodos

        public bool guardar(string archivo, T datos)
        {
            throw new NotImplementedException();
        }

        public bool leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }

        #endregion
        
    }
}
