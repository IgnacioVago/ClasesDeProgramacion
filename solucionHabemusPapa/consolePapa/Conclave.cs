using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePapa
{
    public class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public static int cantidadVotaciones;
        public static DateTime fechaVotacion;
        public static Random random;
        
        #region Constructores

        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Today;
            random = new Random();
        }

        public Conclave()
        {
            this._cardenales = new List<Cardenal>();
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "Capilla sixtina";
        }

        private Conclave(int cantidadCardenales) : this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        public Conclave(int cantidadCardenales, string lugarEleccion) : this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        #endregion

        #region Metodos

        private bool HayLugar()
        {
            if (this._cardenales.Count < this._cantMaxCardenales)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string MostrarCardenales()
        { 
            StringBuilder sbCardenales;
            sbCardenales = new StringBuilder();

            foreach (Cardenal item in this._cardenales)
	        {
		        sbCardenales.AppendLine(Cardenal.Mostrar(item));
	        }

            return sbCardenales.ToString(); 
        }

        public string Mostrar()
        {
            StringBuilder sbConclave;
            sbConclave = new StringBuilder();

            sbConclave.AppendLine("----CONCLAVE----");
            sbConclave.AppendLine("Lugar de votacion: " + this._lugarEleccion);
            sbConclave.AppendLine("Fecha de votacion: " + fechaVotacion);
            sbConclave.AppendLine("Cantidad de votos: " + cantidadVotaciones);

            if (this._habemusPapa == true)
            {
                sbConclave.AppendLine("HABEMUS PAPA");
                sbConclave.AppendLine(this._papa.ObtenerNombreYNombrePapal());
            }
            else
            {
                sbConclave.AppendLine("NO HABEMUS PAPA");
                sbConclave.AppendLine(MostrarCardenales());
            }

            return sbConclave.ToString();
        }

        public static void VotarPapa(Conclave unConclave)
        {
            int indicePapal;

            for (int i = 0; i < unConclave._cardenales.Count; i++)
            {
                indicePapal = random.Next(0,unConclave._cardenales.Count);
                unConclave._cardenales[indicePapal]++;
            }

            Conclave.ContarVotos(unConclave);
        }

        private static void ContarVotos(Conclave unConclave)
        {
            for (int i = 0; i < unConclave._cardenales.Count; i++)
            {
                if (i == 0)
                {
                    unConclave._papa = unConclave._cardenales[i];
                    unConclave._habemusPapa = true;
                }

                if (unConclave._papa.getCantidadVotosRecibidos() < unConclave._cardenales[i].getCantidadVotosRecibidos())
                {
                    unConclave._papa = unConclave._cardenales[i];
                    unConclave._habemusPapa = true;
                }
            }
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Conclave unConclave, Cardenal unCardenal)
        {
            foreach (Cardenal item in unConclave._cardenales)
            {
                if (item == unCardenal)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Conclave unConclave, Cardenal unCardenal)
        {
            foreach (Cardenal item in unConclave._cardenales)
            {
                if (item != unCardenal)
                {
                    return true;
                }
            }

            return false;
        }

        public static Conclave operator +(Conclave unConclave, Cardenal unCardenal)
        {
            if (unConclave.HayLugar() == true)
            {
                if (unConclave == unCardenal)
                {
                    Console.WriteLine("El cardenal ya existe");
                }
                else 
                {
                    unConclave._cardenales.Add(unCardenal);
                    Console.WriteLine("Cardenal correctamente ingresado");
                }                
            }
            else
            {
                Console.WriteLine("No hay lugar");
            }


            return unConclave;
        }

        #endregion

        #region Sobrecarga de operadores de conversion

        public static implicit operator Conclave(int cantidadCardenales)
        {
            Conclave aux;
            aux = new Conclave(cantidadCardenales);

            return aux;
        }

        public static explicit operator bool(Conclave unConclave)
        {
            if (unConclave._habemusPapa == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
