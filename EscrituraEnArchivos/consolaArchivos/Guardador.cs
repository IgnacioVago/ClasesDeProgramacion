using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace consolaArchivos
{
    public static class Guardador
    {
        public static bool GuardarPersona(Persona unaPersona)
        {
            StreamWriter escritorPersonas = null;
            bool bandera;
           
            try
            {
                escritorPersonas = new StreamWriter("personas.txt", true);
                escritorPersonas.Write(unaPersona.ToString());
                
                bandera = true;
            }
            catch (Exception)
            {
                bandera = false;
            }
            finally 
            {
                escritorPersonas.Close();
            }

            return bandera;
        }

        public static Persona LeerUnaPersona()
        {
            Persona auxPersona = null;
            StreamReader lectorPersonas = null;
            string aux;
            string[] arrayString;

            try
            {
                lectorPersonas = new StreamReader("personas.txt");
                aux = lectorPersonas.ReadLine();
                arrayString = aux.Split(',');
                auxPersona = new Persona(arrayString[0], arrayString[1]);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                lectorPersonas.Close();
            }
            
            return auxPersona;
        }

        public static List<Persona> ListadoDePersonas()
        {
            List<Persona> listaDePersonas = null;

            try
            {
                listaDePersonas = new List<Persona>();
                
                using (StreamReader lector = new StreamReader("personas.txt"))
                {
                    string renglon;
                    string[] arrayString;

                    while ((renglon = lector.ReadLine()) != null)
                    {
                        arrayString = renglon.Split(',');
                        listaDePersonas.Add(new Persona(arrayString[0], arrayString[1]));
                    }
                }
            }
            catch (Exception)
            {
                
            }
            
            return listaDePersonas;
        }
    }
}
