using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class NoGuardaException : Exception
    {
        public NoGuardaException() : base()
        { 
            
        }

        public NoGuardaException(string message, Exception e) : base(message)
        { 
            
        }

        public NoGuardaException(Exception e) : this("Error al guardar", e)
        { 
            
        }
    }
}
