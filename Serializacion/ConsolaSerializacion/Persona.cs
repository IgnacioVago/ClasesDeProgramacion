using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsolaSerializacion
{
    [XmlInclude(typeof(Alumno))]
    public class Persona : ISerializable2016
    {
        public string nombre;

        public Persona()
        { 
            
        }

        public Persona(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public bool serializar()
        {
            bool flag = false;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("personaGenerica.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador;
                    serializador = new XmlSerializer(typeof(Persona));

                    serializador.Serialize(escritor, this);
                }

                flag = true;
            }
            catch (Exception)
            {
                return flag;
            }
            finally
            {

            }

            return flag;
        }
    }
}
