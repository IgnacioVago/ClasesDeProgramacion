using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N()
        {
            char rta;
            
            Console.Write("Desea ingresar otro numero? S = si // N = no: ");
            rta = char.Parse(Console.ReadLine());
            rta = char.ToUpper(rta);

            while (!char.IsLetter(rta))
            {
                Console.Write("Reingrese la opcion: ");
                rta = char.Parse(Console.ReadLine());
            }

            while (rta != 'S' && rta != 'N')
            {
                Console.Write("Reingrese la opcion: ");
                rta = char.Parse(Console.ReadLine());    
            }

            if (rta == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
