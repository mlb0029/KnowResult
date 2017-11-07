using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos;

namespace DatosTest
{
    [TestClass]
    public class PruebaTest
    {
        [TestMethod]
        public void TestConstructorSetyGetPrueba()
        {
            Usuario evaluador1 = new Usuario(0, "pjimenez", "Pepito", "Jimenez", Roles.Evaluador, "p.jimenez@evaluador.es", "passwd1");
            Usuario evaluador2 = new Usuario(1, "mjimenez", "Marta", "Jimenez", Roles.Evaluador, "m.jimenez@evaluador.es", "passwd2");
            Prueba p = new Prueba(1, "prueba1", evaluador1);

            Assert.AreEqual(p.IdPrueba, 1);
            Assert.AreEqual(p.Nombre, "prueba1");
            Assert.AreSame(p.Evaluador, evaluador1);

            //p.IdPrueba = 2;
            p.Nombre = "prueba2";
            p.Evaluador = evaluador2;

            //Assert.AreEqual(p.IdPrueba, 2);
            Assert.AreEqual(p.Nombre, "prueba2");
            Assert.AreSame(p.Evaluador, evaluador2);
        }
    }
}
