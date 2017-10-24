using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Prueba
{
    [TestClass]
    public class BDCalificacionTest
    {
        [TestMethod]
        public void TestConstructorSetyGetCalificacion()
        {
            BDCalificacion c = new BDCalificacion(1, 3, 1.5, true);

            Assert.AreEqual(c.IdPrueba, 1);
            Assert.AreEqual(c.IdAspirante, 3);
            Assert.AreEqual(c.Nota, 1.5);
            Assert.AreEqual(c.Calificada, true);

            c.IdPrueba = 2;
            c.IdAspirante = 4;
            c.Nota = 0;
            c.Calificada = false;

            Assert.AreEqual(c.IdPrueba, 2);
            Assert.AreEqual(c.IdAspirante, 4);
            Assert.AreEqual(c.Nota, 0);
            Assert.AreEqual(c.Calificada, false);
        }
    }
}
