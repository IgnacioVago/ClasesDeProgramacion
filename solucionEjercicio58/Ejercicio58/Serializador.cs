using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio58
{
    public static class Serializador
    {
        public static void Texto(string fechaYHoraExcepcion)
        {
            StreamWriter escritor;

            try
            {
                escritor = new StreamWriter("datos.txt");

                escritor.Write(fechaYHoraExcepcion);

                escritor.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error al generar archivo");
            }
        }

        public static void XML(Transatlantico unTransatlantico)
        {
            XmlSerializer serializador;
            XmlTextWriter escritor;

            try
            {
                using (escritor = new XmlTextWriter("transatlantico.xml", Encoding.UTF8))
                {
                    serializador = new XmlSerializer(typeof(Transatlantico));

                    serializador.Serialize(escritor, unTransatlantico);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
