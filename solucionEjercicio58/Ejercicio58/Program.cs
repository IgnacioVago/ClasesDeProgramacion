using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio58
{
    class Program
    {
        static void Main(string[] args)
        {
            Crucero cruceroUno;
            cruceroUno = new Crucero(3, true, "Brasil");

            Transatlantico transatlanticoUno;
            transatlanticoUno = new Transatlantico(3, true, "Australia");

            try
            {
                cruceroUno.Ingresar(new Pasajero("Pollio", "Juan Martin", Pasajero.ERangos.Camarero));
                cruceroUno.Ingresar(new Pasajero("Otero", "Nataniel", Pasajero.ERangos.Cliente));
                cruceroUno.Ingresar(new Pasajero("Rotela", "Gustavo", Pasajero.ERangos.Cocinero));

                transatlanticoUno.Ingresar(new Pasajero("Pollio","Juan Martin",Pasajero.ERangos.Camarero));
                transatlanticoUno.Ingresar(new Pasajero("Otero","Nataniel",Pasajero.ERangos.Cliente));
                transatlanticoUno.Ingresar(new Pasajero("Rotela","Gustavo",Pasajero.ERangos.Cocinero));
                transatlanticoUno.Ingresar(new Pasajero("Martire","Julian",Pasajero.ERangos.Capitan));
            }
            catch (Exception e)
            {
                Serializador.Texto(e.Message);
                
            }

            Serializador.XML(transatlanticoUno);

        }
    }
}
