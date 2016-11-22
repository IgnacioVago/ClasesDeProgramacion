using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        #region Constructores

        public ArchivosException(Exception innerException)
            : base(innerException.Message)
        {

        }

        #endregion
    }
}
