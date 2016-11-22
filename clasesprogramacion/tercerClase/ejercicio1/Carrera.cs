using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Carrera
    {
        /*
         * DEPRETICATED: coleccion.
         * public Auto autoUno;
        public Auto autoDos;
        public Auto autoTres;
        public Auto autoCuatro;
        public Auto autoCinco;
        public Auto autoSeis;*/
        public List<Auto> listaDeAutos;
        private static Random randomkilometros;
        private static Random randomtiempo;
        private string _nombreCarrera;
        private string _fechaCarrera;
        private string _lugarCarrera;
        //public int maximoKm;
        //public int minimoKm;
        //public string automaxKm;
        //public string autominKm;

        #region Constructores

        public Carrera()
        {
            this.listaDeAutos = new List<Auto>();

            //DEPRETICATED: coleccion.
            //this.autoUno = new Auto();
            //this.autoDos = new Auto();
            //this.autoTres = new Auto();
            //this.autoCuatro = new Auto();
            //this.autoCinco = new Auto();
            //this.autoSeis = new Auto();
        }

        public Carrera(string nombrePiloto, string fechaPiloto, string lugarPiloto)
        {
            this._nombreCarrera = nombrePiloto;
            this._fechaCarrera = fechaPiloto;
            this._lugarCarrera = lugarPiloto;
            this.listaDeAutos = new List<Auto>();
        }

        static Carrera()
        {
            randomkilometros = new Random();
            randomtiempo = new Random();
        }

        #endregion

        #region Formas de correr carrera

        public string correrCarreraPorKilometros(Kilometro kilometros)
        {
            int ContadorKms;
            Auto mayor = new Auto();
            Auto menor = new Auto();
            /*string cadmayor;
            string cadmenor;*/

            for (ContadorKms = 0; ContadorKms < (int)kilometros; ContadorKms++)
            {
                foreach (Auto listaAutos in this.listaDeAutos)
                {
                    listaAutos.Agregar((Tiempo)randomkilometros.Next(10, 100));
                }

                for (int elementos = 0; elementos < this.listaDeAutos.Count; elementos++)
                {
                    if (elementos == 0)
                    { 
                        mayor = this.listaDeAutos[elementos];
                        menor = this.listaDeAutos[elementos];
                        continue;
                    }

                    if ((int)mayor.ObtenerTiempo() < (int)this.listaDeAutos[elementos].ObtenerTiempo())
                    {
                        mayor = this.listaDeAutos[elementos];
                    }

                    if ((int)menor.ObtenerTiempo() > (int)this.listaDeAutos[elementos].ObtenerTiempo())
                    {
                        menor = this.listaDeAutos[elementos];
                    }
                }
            }

            /*mayor = autoUno;
            menor = autoUno;
            cadmayor = "AUTO UNO";

            if ((int)mayor.ObtenerTiempo() < (int)this.autoDos.ObtenerTiempo())
            {
                mayor = autoDos;
                cadmayor = "AUTO DOS";
            }
            if ((int)mayor.ObtenerTiempo() < (int)autoTres.ObtenerTiempo())
            {
                mayor = autoTres;
                cadmayor = "AUTO TRES";
            }
            if ((int)mayor.ObtenerTiempo() < (int)autoCuatro.ObtenerTiempo())
            {
                mayor = autoCuatro;
                cadmayor = "AUTO CUATRO";
            }
            if ((int)mayor.ObtenerTiempo() < (int)autoCinco.ObtenerTiempo())
            {
                mayor = autoCinco;
                cadmayor = "AUTO CINCO";
            }
            if ((int)mayor.ObtenerTiempo() < (int)autoSeis.ObtenerTiempo())
            {
                mayor = autoSeis;
                cadmayor = "AUTO SEIS";
            }

            cadmenor = "AUTO UNO";

            if ((int)menor.ObtenerTiempo() > (int)this.autoDos.ObtenerTiempo())
            {
                menor = autoDos;
                cadmenor = "AUTO DOS";
            }
            if ((int)menor.ObtenerTiempo() > (int)autoTres.ObtenerTiempo())
            {
                menor = autoTres;
                cadmenor = "AUTO TRES";
            }
            if ((int)menor.ObtenerTiempo() > (int)autoCuatro.ObtenerTiempo())
            {
                menor = autoCuatro;
                cadmenor = "AUTO CUATRO";
            }
            if ((int)menor.ObtenerTiempo() > (int)autoCinco.ObtenerTiempo())
            {
                menor = autoCinco;
                cadmenor = "AUTO CINCO";
            }
            if ((int)menor.ObtenerTiempo() > (int)autoSeis.ObtenerTiempo())
            {
                menor = autoSeis;
                cadmenor = "AUTO SEIS";
            }*/

            StringBuilder sbAuto = new StringBuilder();

            sbAuto.AppendLine("Informacion del ganador: " + mayor.datosEnString);
            sbAuto.AppendLine("Con un recorrido de: " + (int)mayor.ObtenerTiempo()+" kms");

            return sbAuto.ToString();
        }

        public string correrCarreraPorTiempo(Tiempo tiempo)
        {
            int ContadorTiempo;
            Auto mayor = new Auto();
            Auto menor = new Auto();
            /*string cadmayor;
            string cadmenor;*/

            for (ContadorTiempo = 0; ContadorTiempo < (int)tiempo; ContadorTiempo++)
            {
                foreach (Auto listaAutos in this.listaDeAutos)
                {
                    listaAutos.Agregar((Kilometro)randomtiempo.Next(10, 100));
                }
            }

            for (int elementos = 0; elementos < this.listaDeAutos.Count; elementos++)
            {
                if (elementos == 0)
                { 
                    mayor = this.listaDeAutos[elementos];
                    menor = this.listaDeAutos[elementos];
                    continue;
                }

                if ((int)mayor.ObtenerKms() < (int)this.listaDeAutos[elementos].ObtenerKms())
                {
                    mayor = this.listaDeAutos[elementos];
                }

                if ((int)menor.ObtenerKms() > (int)this.listaDeAutos[elementos].ObtenerKms())
                {
                    menor = this.listaDeAutos[elementos];
                }
            }

            /*
             * DEPRETICATED POR COLECCIONES
             * mayor = autoUno;
            menor = autoUno;
            cadmayor = "AUTO UNO";

            if ((int)mayor.ObtenerKms() < (int)this.autoDos.ObtenerKms())
            {
                mayor = autoDos;
                cadmayor = "AUTO DOS";
            }
            if ((int)mayor.ObtenerKms() < (int)autoTres.ObtenerKms())
            {
                mayor = autoTres;
                cadmayor = "AUTO TRES";
            }
            if ((int)mayor.ObtenerKms() < (int)autoCuatro.ObtenerKms())
            {
                mayor = autoCuatro;
                cadmayor = "AUTO CUATRO";
            }
            if ((int)mayor.ObtenerKms() < (int)autoCinco.ObtenerKms())
            {
                mayor = autoCinco;
                cadmayor = "AUTO CINCO";
            }
            if ((int)mayor.ObtenerKms() < (int)autoSeis.ObtenerKms())
            {
                mayor = autoSeis;
                cadmayor = "AUTO SEIS";
            }

            cadmenor = "AUTO UNO";

            if ((int)menor.ObtenerKms() > (int)this.autoDos.ObtenerKms())
            {
                menor = autoDos;
                cadmenor = "AUTO DOS";
            }
            if ((int)menor.ObtenerKms() > (int)autoTres.ObtenerKms())
            {
                menor = autoTres;
                cadmenor = "AUTO TRES";
            }
            if ((int)menor.ObtenerKms() > (int)autoCuatro.ObtenerKms())
            {
                menor = autoCuatro;
                cadmenor = "AUTO CUATRO";
            }
            if ((int)menor.ObtenerKms() > (int)autoCinco.ObtenerKms())
            {
                menor = autoCinco;
                cadmenor = "AUTO CINCO";
            }
            if ((int)menor.ObtenerKms() > (int)autoSeis.ObtenerKms())
            {
                menor = autoSeis;
                cadmenor = "AUTO SEIS";
            }*/

            StringBuilder sbAuto;
            sbAuto = new StringBuilder();

            sbAuto.AppendLine("Informacion del piloto ganador: " + menor.datosEnString);
            sbAuto.AppendLine("Con un tiempo de: " + (int)menor.ObtenerKms() + " minutos");

            return sbAuto.ToString();
        }

        #endregion

        #region Operadores y sobrecarga de operadores

        private bool agregarAuto(Auto unAuto)
        {
            this.listaDeAutos.Add(unAuto);
            return true;
        }

        public static Carrera operator +(Carrera unaCarrera, Auto unAuto)
        {
            unaCarrera.agregarAuto(unAuto);
            return unaCarrera;
        }

        #endregion

        public string mostrarCarreraTotal()
        {
            StringBuilder sbCarrera = new StringBuilder();

            sbCarrera.AppendLine("-Carrera-");

            foreach (Auto listaAutos in this.listaDeAutos)
            {
                sbCarrera.AppendLine(listaAutos.retornarString());
            }

            return sbCarrera.ToString();

            /*  DEPRETICATED: collecion.
             * 
             * this.autoUno.MostrarAuto();
            this.autoDos.MostrarAuto();
            this.autoTres.MostrarAuto();
            this.autoCuatro.MostrarAuto();
            this.autoCinco.MostrarAuto();
            this.autoSeis.MostrarAuto();*/
            
        }

        public string mostrarCarrera
        {
            get
            {
                return this.mostrarCarreraTotal();
            }
        }

    }
}
