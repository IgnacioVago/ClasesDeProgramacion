using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Laboratorio
    {
        private string nombre;
        public List<PC> listaDePC;

        #region Constructores

        public Laboratorio(string nombre)
        {
            this.nombre = nombre;
            this.listaDePC = new List<PC>();
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sbLaboratorio;
            sbLaboratorio = new StringBuilder();

            sbLaboratorio.AppendLine("Laboratorio: " + this.nombre);

            return sbLaboratorio.ToString();
        }

        #endregion

        #region Propiedades

        public PC this[int indice]
        {
            get
            {
                if (indice >= 0 && indice <= this.listaDePC.Count)
                {
                    return this.listaDePC[indice];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (indice == this.listaDePC.Count)
                {
                    this.listaDePC.Add(value);
                }
                else
                {
                    if (indice >= 0 && indice < this.listaDePC.Count)
                    {
                        this.listaDePC[indice] = value;                       
                    }
                }
            }
        }

        #endregion

        #region Sobrecargas

        #endregion
    }
}
