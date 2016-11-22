using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio58
{
    public class PasajerosOverFlowException : Exception
    {

        public PasajerosOverFlowException(string message) : base(message)
        {
            
        }
    }
}
