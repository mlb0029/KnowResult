using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Prueba
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void TestConstructorSetyGet()
        {
            Usuario u = new Usuario(1, "cuenta", "cuenta@ubu.es");

            Assert.AreEqual(u.IdUsuario, 1);
            Assert.AreEqual(u.Cuenta, "cuenta");
            Assert.AreEqual(u.Email, "cuenta@ubu.es");
        }
    }
}
