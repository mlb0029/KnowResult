using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Prueba
{
    [TestClass]
    public class UsuarioTest
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
        }
    }
}
