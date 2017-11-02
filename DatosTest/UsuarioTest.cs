using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos;

namespace DatosTest
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod()]
        public void TestConstructorSetyGetUsuario()
        {
            Usuario u = new Usuario(0, "aperez", "Antonio", "Pérez de Frutos", Roles.Aspirante, "a.perez@aspirante.es", "password1");

            Assert.AreEqual(u.IdUsuario, 0);
            Assert.AreEqual(u.Cuenta, "aperez");
            Assert.AreEqual(u.EMail, "a.perez@aspirante.es");
            Assert.AreEqual(u.Nombre, "Antonio");
            Assert.AreEqual(u.Apellidos, "Pérez de Frutos");
            Assert.AreEqual(u.Rol, Roles.Aspirante);
            Assert.AreEqual(u.Password, "password1");

            //u.IdUsuario = 2;
            u.Cuenta = "jrodriguez";
            u.Nombre = "Jorge";
            u.Apellidos = "Rodriguez";
            u.Rol = Roles.Evaluador;
            u.EMail = "j.rodriguez@evaluador.es";

            //Assert.AreEqual(u.IdUsuario, 2);
            Assert.AreEqual(u.Cuenta, "jrodriguez");
            Assert.AreEqual(u.EMail, "j.rodriguez@evaluador.es");
            Assert.AreEqual(u.Nombre, "Jorge");
            Assert.AreEqual(u.Apellidos, "Rodriguez");
            Assert.AreEqual(u.Rol, Roles.Evaluador);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void constructorConArgumentosNulos()
        {
            Usuario u = new Usuario(1, "aperez", null, "Pérez de Frutos", Roles.Administrador, "a.perez@aspirante.es", "password1");
        }
    }
}
