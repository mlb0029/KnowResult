using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos;

namespace DatosTest
{
    [TestClass]
    public class CalificacionTest
    {
        [TestMethod]
        public void TestConstructorSetyGetCalificacion()
        {
            Usuario aspirante = new Usuario(0, "pjimenez", "Pepito", "Jimenez", Roles.Aspirante, "p.jimenez@aspirante.es", "passwd1");
            Usuario evaluador = new Usuario(1, "mjimenez", "Marta", "Jimenez", Roles.Evaluador, "m.jimenez@evaluador.es", "passwd2");
            Prueba prueba = new Prueba(0, "Prueba1", evaluador);
            Calificacion c = new Calificacion(prueba, aspirante, 0, false);

            Assert.AreEqual(c.Prueba, prueba);
            Assert.AreEqual(c.Aspirante, aspirante);
            Assert.AreEqual(c.Nota, 0);
            Assert.AreEqual(c.Calificada, false);

            Assert.AreEqual(c.Prueba.Nombre, "Prueba1");
            Assert.AreEqual(c.Prueba.Evaluador, evaluador);

            Assert.AreEqual(c.Prueba.Evaluador.IdUsuario, 1);
            Assert.AreEqual(c.Prueba.Evaluador.Cuenta, "mjimenez");
            Assert.AreEqual(c.Prueba.Evaluador.Nombre, "Marta");
            Assert.AreEqual(c.Prueba.Evaluador.Apellidos, "Jimenez");
            Assert.AreEqual(c.Prueba.Evaluador.Rol, Roles.Evaluador);
            Assert.AreEqual(c.Prueba.Evaluador.EMail, "m.jimenez@evaluador.es");
            Assert.AreEqual(c.Prueba.Evaluador.Password, "passwd2");

            Assert.AreEqual(c.Aspirante, aspirante);
            Assert.AreEqual(c.Aspirante.IdUsuario, 0);
            Assert.AreEqual(c.Aspirante.Cuenta, "pjimenez");
            Assert.AreEqual(c.Aspirante.Nombre, "Pepito");
            Assert.AreEqual(c.Aspirante.Apellidos, "Jimenez");
            Assert.AreEqual(c.Aspirante.Rol, Roles.Aspirante);
            Assert.AreEqual(c.Aspirante.EMail, "p.jimenez@aspirante.es");
            Assert.AreEqual(c.Aspirante.Password, "passwd1");

            c.Nota = 3.5;
            c.Calificada = true;

            Assert.AreEqual(c.Nota, 3.5);
            Assert.AreEqual(c.Calificada, true);

            evaluador.Nombre = "Juan";
            Assert.AreEqual(c.Prueba.Evaluador.Nombre, "Juan");
            aspirante.EMail = "p.jimenez@aspirante2.es";
            Assert.AreEqual(c.Aspirante.EMail, "p.jimenez@aspirante2.es");
        }
    }
}
