using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = 0;
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            int cont7 = 0;
            int cont8 = 0;
            int cont9 = 0;
            int cont10 = 0;
            int total = 10000;
            int prom1 = 0;
            int prom2 = 0;
            int prom3 = 0;
            int prom4 = 0;
            int prom5 = 0;
            int prom6 = 0;
            int prom7 = 0;
            int prom8 = 0;
            int prom9 = 0;
            int prom10 = 0;
            Random random = new Random();

            for (; contador < total; contador++)
            {
                
                numero = random.Next(1,11);

                switch (numero)
                {
                    case 1:
                        cont1++;
                        break;
                    case 2:
                        cont2++;
                        break;
                    case 3:
                        cont3++;
                        break;
                    case 4:
                        cont4++;
                        break;
                    case 5:
                        cont5++;
                        break;
                    case 6:
                        cont6++;
                        break;
                    case 7:
                        cont7++;
                        break;
                    case 8:
                        cont8++;
                        break;
                    case 9:
                        cont9++;
                        break;
                    case 10:
                        cont10++;
                        break;
                }
            }

            prom1 = (cont1 * 100) / total;
            prom2 = (cont2 * 100) / total;
            prom3 = (cont3 * 100) / total;
            prom4 = (cont4 * 100) / total;
            prom5 = (cont5 * 100) / total;
            prom6 = (cont6 * 100) / total;
            prom7 = (cont7 * 100) / total;
            prom8 = (cont8 * 100) / total;
            prom9 = (cont9 * 100) / total;
            prom10 = (cont10 * 100) / total;

            Console.Write("Cantidad de numeros 1: " + cont1);
            Console.Write("\nCantidad de numeros 2: " + cont2);
            Console.Write("\nCantidad de numeros 3: " + cont3);
            Console.Write("\nCantidad de numeros 4: " + cont4);
            Console.Write("\nCantidad de numeros 5: " + cont5);
            Console.Write("\nCantidad de numeros 6: " + cont6);
            Console.Write("\nCantidad de numeros 7: " + cont7);
            Console.Write("\nCantidad de numeros 8: " + cont8);
            Console.Write("\nCantidad de numeros 9: " + cont9);
            Console.Write("\nCantidad de numeros 10: " + cont10);
            Console.Write("\nPromedio contador 1: " + prom1+"%");
            Console.Write("\nPromedio contador 2: " + prom2+"%");
            Console.Write("\nPromedio contador 3: " + prom3 + "%");
            Console.Write("\nPromedio contador 4: " + prom4 + "%");
            Console.Write("\nPromedio contador 5: " + prom5 + "%");
            Console.Write("\nPromedio contador 6: " + prom6 + "%");
            Console.Write("\nPromedio contador 7: " + prom7 + "%");
            Console.Write("\nPromedio contador 8: " + prom8 + "%");
            Console.Write("\nPromedio contador 9: " + prom9 + "%");
            Console.Write("\nPromedio contador 10: " + prom10 + "%");

            Console.ReadKey();
            
        }
    }
}
