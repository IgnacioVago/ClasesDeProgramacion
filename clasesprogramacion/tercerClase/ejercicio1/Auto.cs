using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Auto
    {
        private string _nombrePiloto;
        private EFabricante _fabricanteAuto;
        private EFabricante fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        public static int contadorObjetos;
        private Kilometro kilometrosRecorridos;
        private static Random randomFabricante;
        private Tiempo tiempoTardado;

        public Auto()
        {
            //Random random = new Random();
            int numero;
            numero = randomFabricante.Next(0, 9);
            this.fabricante = (EFabricante)numero;
            this.TI = new Rueda();
            this.TD = new Rueda();
            this.DD = new Rueda();
            this.DI = new Rueda();
            Auto.contadorObjetos++;
            this.tiempoTardado = 0;
            this.kilometrosRecorridos = 0;
        }

        public Auto(string nombrePiloto, EFabricante fabricanteAuto) : this()
        {
            this._nombrePiloto = nombrePiloto;
            this._fabricanteAuto = fabricanteAuto;
        }

        public static bool compararAuto(Auto autoUno, Auto autoDos)
        {
            if (autoUno.fabricante == autoDos.fabricante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static Auto() //se ejecuta apenas se llame a la clase y se ejecuta una vez
        {
            Auto.contadorObjetos = 0; 
            randomFabricante = new Random();
        }

        /*public void MostrarAuto()
        {
            Console.Write("Fabricante: " + this.fabricante);
        }*/

        public string retornarString()
        {
            StringBuilder sbAuto = new StringBuilder();

            sbAuto.AppendLine("Fabricante: " + this.fabricante);
            sbAuto.AppendLine("Tiempo: " + (int)this.tiempoTardado);
            sbAuto.AppendLine("Kms: " + (int)this.kilometrosRecorridos);

            return sbAuto.ToString();
        }

        private string retornarStringParaListado()
        {
            StringBuilder sbAutito = new StringBuilder();

            sbAutito.AppendLine("Piloto: " + this._nombrePiloto+" - ");
            sbAutito.AppendLine("Fabricante: " + this._fabricanteAuto);

            return sbAutito.ToString();
        }

        private string retornarStringParaListadoTiempo()
        {
            StringBuilder sbAutito = new StringBuilder();

            sbAutito.AppendLine("P: " + this._nombrePiloto + " - ");
            sbAutito.AppendLine("F: " + this._fabricanteAuto);
            sbAutito.AppendLine("T: " + (int)this.tiempoTardado);

            return sbAutito.ToString();
        }

        public void volverACero()
        {
            this.tiempoTardado = 0;
            this.kilometrosRecorridos = 0;
        }

        public Kilometro ObtenerKms()
        {
            return this.kilometrosRecorridos;
        }

        public Tiempo ObtenerTiempo()
        {
            return this.tiempoTardado;
        }

        public void Agregar(Tiempo tiempo)
        {
            this.tiempoTardado = this.tiempoTardado + tiempo;
        }

        public void Agregar(Kilometro kilometros)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + kilometros;
        }

        public string datosEnString
        {
            get
            {
                return this.retornarStringParaListado();
            }
        }

        public string datosCarreraTiempoString
        {
            get
            {
                return this.retornarStringParaListadoTiempo();
            }
        }

        public static int ordenarPorMarcaAZ(Auto autoUno, Auto autoDos) 
        {
            return String.Compare(autoUno._fabricanteAuto.ToString(), autoDos._fabricanteAuto.ToString());
        }

        public static int ordenarPorMarcaZA(Auto autoUno, Auto autoDos)
        {
            return String.Compare(autoDos._fabricanteAuto.ToString(), autoUno._fabricanteAuto.ToString());
        }

        public static int ordenarPorPilotoAZ(Auto autoUno, Auto autoDos)
        {
            return String.Compare(autoUno._nombrePiloto, autoDos._nombrePiloto);
        }

        public static int ordenarPorPilotoZA(Auto autoUno, Auto autoDos)
        {
            return String.Compare(autoDos._nombrePiloto, autoUno._nombrePiloto);
        }
    }
}
