using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsolaSerializacion
{
    public static class Serializador
    {
        public static void SerializarPersona(Persona unaPersona)
        {
            //XmlTextWriter escritorXML;
            //XmlSerializer serializador;

            using (XmlTextWriter escritor = new XmlTextWriter("persona.xml",Encoding.UTF8))
            {
                XmlSerializer serializador;
                serializador = new XmlSerializer(typeof(Persona));

                serializador.Serialize(escritor, unaPersona);
            }

        }

        public static void SerializarListadoDePersonas(List<Persona> listaDePersonas)
        {
            //XmlTextWriter escritorXML;
            //XmlSerializer serializador;

            using (XmlTextWriter escritor = new XmlTextWriter("listadoDePersonas.xml", Encoding.UTF8))
            {
                XmlSerializer serializador;
                serializador = new XmlSerializer(typeof(List<Persona>));

                serializador.Serialize(escritor, listaDePersonas);
            }

        }

        public static void SerializarAula(Aula aula)
        {
            //XmlTextWriter escritorXML;
            //XmlSerializer serializador;

            using (XmlTextWriter escritor = new XmlTextWriter("aula.xml", Encoding.UTF8))
            {
                XmlSerializer serializador;
                serializador = new XmlSerializer(typeof(Aula));

                serializador.Serialize(escritor, aula);
            }

        }

        public static bool SerializarGenerico(ISerializable2016 o)
        {
            return o.serializar();
        }

        public static bool DeserializarPersona()
        {
            //XmlTextWriter escritorXML;
            //XmlSerializer serializador;

            Persona auxPersona = null;

            using (XmlTextReader lector = new XmlTextReader("persona.xml"))
            {
                XmlSerializer serializador;
                serializador = new XmlSerializer(typeof(Persona));

                auxPersona = (Persona)serializador.Deserialize(lector);

                if (auxPersona == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
