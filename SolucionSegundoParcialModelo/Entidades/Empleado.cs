using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    [Serializable]
    public class Empleado : Persona, IArchivos<Empleado>
    {
        private int _legajo;

        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public Empleado()
        {
        
        }

        public Empleado(string nombre, string apellido, int legajo) : base(nombre, apellido)
        {
            this._legajo = legajo;
        }

        public static string MostrarDatos(Empleado e)
        {
            return e.ToString();
        }

        public bool guardar(string archivo, Empleado datos)
        {
            XmlSerializer serializador;
            XmlTextWriter escritor;

            try
            {
                escritor = new XmlTextWriter(archivo, Encoding.UTF8);
                serializador = new XmlSerializer(typeof(Empleado));

                serializador.Serialize(escritor, datos);

                escritor.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new NoGuardaException(e);
            }
        }

        public bool leer(string archivo, out Empleado datos)
        {
            XmlTextReader lector;
            XmlSerializer serializador;

            try
            {
                lector = new XmlTextReader(archivo);
                serializador = new XmlSerializer(typeof(Empleado));

                datos = (Empleado)serializador.Deserialize(lector);

                return true;
            }
            catch (Exception e)
            {
                datos = default(Empleado);
                throw new NoLeeException(e);
            }
        }

        public int LegajoDos
        {
            set
            {
                this.Legajo = value;
            }
            get
            {
                return this.Legajo;
            }
        }
    }
}
