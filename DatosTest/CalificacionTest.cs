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
            Calificacion c = new Calificacion(prueba, aspirante);

            Assert.AreSame(c.Prueba, prueba);
            Assert.AreSame(c.Aspirante, aspirante);
            Assert.AreEqual(c.Nota, 0);
            Assert.AreEqual(c.Calificada, false);

            c.Nota = 3.5;
            c.Calificada = true;

            Assert.AreEqual(c.Nota, 3.5);
            Assert.AreEqual(c.Calificada, true);
        }
    }
}