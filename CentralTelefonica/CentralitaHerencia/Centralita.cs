using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region Constructores

        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        #endregion

        #region Metodos

        private float calcularGanancia(TipoLlamada tipo)
        {
            float gananciaProvincial = 0;
            float gananciaLocal = 0;
            float gananciaTotal;
            Provincial auxProvincial;
            Local auxLocal;

            switch (tipo)
	        {
		        case TipoLlamada.Local:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            auxLocal = (Local)item;
                            gananciaLocal = auxLocal.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            auxProvincial = (Provincial)item;
                            gananciaProvincial = auxProvincial.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            auxLocal = (Local)item;
                            gananciaLocal = auxLocal.CostoLlamada;
                        }

                        if (item.GetType() == typeof(Provincial))
                        {
                            auxProvincial = (Provincial)item;
                            gananciaProvincial = auxProvincial.CostoLlamada;
                        }
                    }
                    break;
	        }

            gananciaTotal = gananciaProvincial + gananciaLocal;

            return gananciaTotal;
        }

        public void mostrarCentralita()
        {
            Provincial auxProvincial;
            Local auxLocal;
            StringBuilder sbGanancias;
            sbGanancias = new StringBuilder();

            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item.GetType() == typeof(Local))
                {
                    auxLocal = (Local)item;
                    auxLocal.mostrarLocal();
                }

                if (item.GetType() == typeof(Provincial))
                {
                    auxProvincial = (Provincial)item;
                    auxProvincial.mostrarProvincial();
                }
            }

            sbGanancias.AppendLine("-----CENTRALITA-----");
            sbGanancias.AppendLine("Razon social: " + this._razonSocial);
            sbGanancias.AppendLine("Ganancias locales: "+this.GananciaPorLocal);
            sbGanancias.AppendLine("Ganancias provinciales: "+this.GananciaPorProvincial);
            sbGanancias.AppendLine("Ganancias totales: "+this.GananciaTotal);

            Console.WriteLine(sbGanancias);
        }

        public void ordenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.ordenarPorDuracion);
        }

        #endregion

        #region Propiedades

        public float GananciaPorLocal
        {
            get
            {
                return this.calcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.calcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.calcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        #endregion

    }
}
