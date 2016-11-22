using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class PC
    {
        private string marca;
        private string SO;
        private int numeroPC;
        private static int contadorPC;
        
        #region Constructores

        /*public PC(string marca, string sistemaOperativo) : this(marca)
        {
            this.SO = sistemaOperativo;
        }*/

        private PC(string marca)
        {
            this.marca = marca;
            this.numeroPC = contadorPC;
            this.SO = "Windows";
            contadorPC++;
        }

        static PC()
        {
            contadorPC = 1;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sbPC;
            sbPC = new StringBuilder();

            sbPC.AppendLine("---PC---");
            sbPC.AppendLine("Marca: "+this.marca);
            sbPC.AppendLine("Numero de PC: "+this.numeroPC);
            sbPC.AppendLine("S.O: "+this.SO);

            return sbPC.ToString();
        }

        #endregion

        #region Propiedades
        
        #endregion

        #region Sobrecargas

        public static implicit operator PC(string marca)
        {
            return new PC(marca);
        }
        
        #endregion
    }
}
