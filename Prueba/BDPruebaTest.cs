using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace UnitTestProject1
{
    [TestClass]
    public class PruebaTest
    {
        [TestMethod]
        public void TestConstructorSetyGetPrueba()
        {
            BDPrueba p = new BDPrueba(1, "prueba1", 3);

            Assert.AreEqual(p.IdPrueba, 1);
            Assert.AreEqual(p.Nombre, "prueba1");
            Assert.AreEqual(p.Evaluador, 3);

            p.IdPrueba = 2;
            p.Nombre = "prueba2";
            p.Evaluador = 3;

            Assert.AreEqual(p.IdPrueba, 2);
            Assert.AreEqual(p.Nombre, "prueba2");
            Assert.AreEqual(p.Evaluador, 3);
        }
    }
}
