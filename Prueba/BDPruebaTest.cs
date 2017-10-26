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
            BDUsuario u = new BDUsuario(1, "pjimenez", "Pepito", "Jimenez", 1, "p.jimenez@evaluador.es");
            BDUsuario u2 = new BDUsuario(1, "mjimenez", "Marta", "Jimenez", 1, "m.jimenez@evaluador.es");
            BDPrueba p = new BDPrueba(1, "prueba1", u);

            Assert.AreEqual(p.IdPrueba, 1);
            Assert.AreEqual(p.Nombre, "prueba1");
            Assert.AreEqual(p.Evaluador, u);

            p.IdPrueba = 2;
            p.Nombre = "prueba2";
            p.Evaluador = 3;

            Assert.AreEqual(p.IdPrueba, 2);
            Assert.AreEqual(p.Nombre, "prueba2");
            Assert.AreEqual(p.Evaluador, 3);
        }
    }
}
