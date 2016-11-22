using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolaTesteando;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        //DEBE INSTANCIAR EL ESTACIONAMIENTO

        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento estacionamientoUno;
            estacionamientoUno = new Estacionamiento();

            Assert.IsNotNull(estacionamientoUno);
        }

        //DEBE INSTANCIAR LA LISTA DE AUTOS EN EL ESTACIONAMIENTO

        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento estacionamientoDos;
            estacionamientoDos = new Estacionamiento();

            Assert.IsNotNull(estacionamientoDos.listaDeAutos);
        }
    }
}
