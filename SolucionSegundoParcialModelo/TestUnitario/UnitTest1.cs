using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MetodoNoGuardar()
        {
            Empleado miEmpleado;
            miEmpleado = new Empleado("Juan Martin", "Pollio", 40916958);

            try
            {
                miEmpleado.guardar("C:\\QUEUEUE\\listadecompras.xml", miEmpleado);

                Assert.Fail("Error al capturar la excepcion");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NoGuardaException));
            }
        }

        [TestMethod]
        public void MetodoLeeYGuarda()
        {
            Empleado miEmpleado;
            miEmpleado = new Empleado("Juan Martin", "Pollio", 40916958);

            try
            {
                Empleado aux;

                miEmpleado.guardar("empleado.xml", miEmpleado);
                miEmpleado.leer("empleado.xml", out aux);

                Assert.AreEqual(miEmpleado.Nombre, aux.Nombre);
                Assert.AreEqual(miEmpleado.Apellido, aux.Apellido);
                Assert.AreEqual(miEmpleado.LegajoDos, miEmpleado.LegajoDos);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
