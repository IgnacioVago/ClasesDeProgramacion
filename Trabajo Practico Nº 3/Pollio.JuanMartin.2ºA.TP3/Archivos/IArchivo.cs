using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archivos
{
    interface IArchivo<T>
    {
        #region Metodos

        bool guardar(string archivo, T datos);
        bool leer(string archivo, T datos);

        #endregion
    }
}
