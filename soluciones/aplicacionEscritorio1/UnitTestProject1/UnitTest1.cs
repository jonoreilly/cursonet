using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using aplicacionEscritorio1WinForms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConcatenarMensajeTest()
        {
            Mensaje miMensaje = new Mensaje();
            string[] mensajes = {"Hola", "desde", "el test"};

            string expected = "Hola desde el test ";

            string actual = miMensaje.ConcatenarMensajes(mensajes);


            Assert.AreEqual(expected, actual);

        }
    }
}