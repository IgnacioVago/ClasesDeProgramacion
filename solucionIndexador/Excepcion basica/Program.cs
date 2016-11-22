using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    class Program
    {
        static void Main(string[] args)
        {

            try //se ejecuta, si da error se ejecuta el catch
            {
                Program.lanzarError();
                Program.Operar();
            }
            catch (FormatException ex) //excepcion de error de formato
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) //excepcion de dividir por 0
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //captura una excepcion
            {
                Console.WriteLine(ex.Message);
            }
            finally //se liberan todos los archivos/recursos usados
            { 
                
            }
            
            Console.ReadLine();
        }

        public static void Operar()
        {
            string dato;
            int numero;

            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception ex)
            {
                // operaciones para guardar informacion de la excepcion
                throw new Exception("Se quedó sin internet.");
            }
        }

        public static void lanzarError()
        {
            throw new Exception("Se quedó sin memoria RAM");
        }
    }
}
