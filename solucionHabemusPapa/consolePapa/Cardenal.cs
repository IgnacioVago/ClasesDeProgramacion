using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePapa
{
    public class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        #region Constructores
        
        private Cardenal()
        {
            this._cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal) : this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad) : this(nombre, nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }

	    #endregion

        #region Metodos
		 
        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        public string ObtenerNombreYNombrePapal()
        {
            StringBuilder sbPapa;
            sbPapa = new StringBuilder();

            sbPapa.AppendLine("El cardenal '"+this._nombre+"' se llamará Papa '"+this._nombrePapal+"'");

            return sbPapa.ToString();
        }

        private string Mostrar()
        {
            StringBuilder sbPapa;
            sbPapa = new StringBuilder();

            sbPapa.AppendLine(ObtenerNombreYNombrePapal());
            sbPapa.AppendLine("Cantidad de votos recibidos: " + this._cantVotosRecibidos);
            sbPapa.AppendLine("Nacionalidad: " + this._nacionalidad);

            return sbPapa.ToString();
        }

        public static string Mostrar(Cardenal unCardenal)
        {
            StringBuilder sbPapa;
            sbPapa = new StringBuilder();

            sbPapa.AppendLine("------INFORMACION DEL CARDENAL------");
            sbPapa.AppendLine("Nombre: " + unCardenal._nombre);
            sbPapa.AppendLine("Nombre papal: " + unCardenal._nombrePapal);
            sbPapa.AppendLine("Nacionalidad: " + unCardenal._nacionalidad);
            sbPapa.AppendLine("Votos recibidos: " + unCardenal._cantVotosRecibidos);

            return sbPapa.ToString();
        }

	    #endregion

        #region Sobrecargas

        public static bool operator ==(Cardenal cardenalUno, Cardenal cardenalDos)
        {
            if (cardenalUno._nombre == cardenalDos._nombre)
            {
                if (cardenalUno._nombrePapal == cardenalDos._nombrePapal)
                {
                    if (cardenalUno._nacionalidad == cardenalDos._nacionalidad)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cardenal cardenalUno, Cardenal cardenalDos)
        {
            if (cardenalUno._nombre != cardenalDos._nombre)
            {
                if (cardenalUno._nombrePapal != cardenalDos._nombrePapal)
                {
                    if (cardenalUno._nacionalidad != cardenalDos._nacionalidad)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Cardenal operator ++(Cardenal unCardenal)
        {
            unCardenal._cantVotosRecibidos = unCardenal._cantVotosRecibidos + 1;

            return unCardenal;
        }

        #endregion
    }
}
