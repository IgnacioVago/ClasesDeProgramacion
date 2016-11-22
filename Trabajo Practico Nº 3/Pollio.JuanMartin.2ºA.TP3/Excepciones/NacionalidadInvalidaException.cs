﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        #region Constructores

        public NacionalidadInvalidaException()
            : base()
        {

        }

        public NacionalidadInvalidaException(string message)
            : base(message)
        {

        }


        #endregion
    }
}
