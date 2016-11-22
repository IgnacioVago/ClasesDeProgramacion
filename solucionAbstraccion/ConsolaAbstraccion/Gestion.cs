using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAbstraccion
{
    public class Gestion
    {
        #region Metodos

        public static float MostrarImp(IAfip impuesto)
        {
            return impuesto.RetornarImpuesto();
        }

        #endregion
    }
}
