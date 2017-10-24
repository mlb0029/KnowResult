using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Prueba
{
    [TestClass]
    public class BDUsuarioTest
    {
        [TestMethod]
        public void TestConstructorSetyGetUsuario()
        {
            BDUsuario u = new BDUsuario(1, "aperez", "Antonio", "Pérez de Frutos", 2, "a.perez@aspirante.es");

            Assert.AreEqual(u.IdUsuario, 1);
            Assert.AreEqual(u.Cuenta, "aperez");
            Assert.AreEqual(u.EMail, "a.perez@aspirante.es");
            Assert.AreEqual(u.Nombre, "Antonio");
            Assert.AreEqual(u.Apellidos, "Pérez de Frutos");
            Assert.AreEqual(u.Rol, 2);

            u.IdUsuario = 2;
            u.Cuenta = "jrodriguez";
            u.Nombre = "Jorge";
            u.Apellidos = "Rodriguez";
            u.Rol = 1;
            u.EMail = "j.rodriguez@evaluador.es";

            Assert.AreEqual(u.IdUsuario, 2);
            Assert.AreEqual(u.Cuenta, "jrodriguez");
            Assert.AreEqual(u.EMail, "j.rodriguez@evaluador.es");
            Assert.AreEqual(u.Nombre, "Jorge");
            Assert.AreEqual(u.Apellidos, "Rodriguez");
            Assert.AreEqual(u.Rol, 1);
        }
    }
}
