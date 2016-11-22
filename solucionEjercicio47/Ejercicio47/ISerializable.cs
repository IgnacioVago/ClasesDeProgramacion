using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio47
{
    public interface ISerializable<T>
    {
        bool serializar(string archivo, T datos);
    }
}
