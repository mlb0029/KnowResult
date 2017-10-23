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
            BDprueba a = new BDprueba(1, "prueba","Pablo");

            Assert.AreEqual(a.IdPrueba, 1);
            Assert.AreEqual(a.Nombre, "prueba");
            Assert.AreEqual(a.Evaluador, "Pablo");


        }
    }
}
