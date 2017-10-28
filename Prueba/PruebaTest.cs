using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace TestLogica
{
    [TestClass]
    public class PruebaTest
    {
        [TestMethod]
        public void TestConstructorSetyGetPrueba()
        {
            Usuario evaluador1 = new Usuario(0, "pjimenez", "Pepito", "Jimenez", Roles.Evaluador, "p.jimenez@evaluador.es","passwd1");
            Usuario evaluador2 = new Usuario(1, "mjimenez", "Marta", "Jimenez", Roles.Evaluador, "m.jimenez@evaluador.es","passwd2");
            Prueba p = new Prueba(1, "prueba1", evaluador1);

            Assert.AreEqual(p.IdPrueba, 1);
            Assert.AreEqual(p.Nombre, "prueba1");
            Assert.AreEqual(p.Evaluador, evaluador1);

            Assert.AreEqual(p.Evaluador.IdUsuario, 0);
            Assert.AreEqual(p.Evaluador.Cuenta, "pjimenez");
            Assert.AreEqual(p.Evaluador.Nombre, "Pepito");
            Assert.AreEqual(p.Evaluador.Apellidos, "Jimenez");
            Assert.AreEqual(p.Evaluador.Rol, Roles.Evaluador);
            Assert.AreEqual(p.Evaluador.EMail, "p.jimenez@evaluador.es");
            Assert.AreEqual(p.Evaluador.Password, "passwd1");

            p.IdPrueba = 2;
            p.Nombre = "prueba2";
            p.Evaluador = evaluador2;

            Assert.AreEqual(p.IdPrueba, 2);
            Assert.AreEqual(p.Nombre, "prueba2");
            Assert.AreEqual(p.Evaluador, evaluador2);

            Assert.AreEqual(p.Evaluador.IdUsuario, 1);
            Assert.AreEqual(p.Evaluador.Cuenta, "mjimenez");
            Assert.AreEqual(p.Evaluador.Nombre, "Marta");
            Assert.AreEqual(p.Evaluador.Apellidos, "Jimenez");
            Assert.AreEqual(p.Evaluador.Rol, Roles.Evaluador);
            Assert.AreEqual(p.Evaluador.EMail, "m.jimenez@evaluador.es");
            Assert.AreEqual(p.Evaluador.Password, "passwd2");

            evaluador2.Apellidos = "Rodriguez";
            Assert.AreEqual(p.Evaluador.Apellidos, "Rodriguez");
        }
    }
}
