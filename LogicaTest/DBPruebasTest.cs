using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using Datos;

namespace LogicaTest
{
    [TestClass]
    public class DBPruebasTest
    {
        [TestMethod]
        public void TestDBPruebas()
        {
            //Contructor, numUsuarios, numPruebas, numCalificaciones, leeUsuario, leePrueba, leeCalificacion
            DBPruebas database = new DBPruebas();
            Assert.AreEqual(database.numUsuarios(), 12);
            Assert.AreEqual(database.numPruebas(), 5);
            Assert.AreEqual(database.numCalifiCaciones(), 27);
            Assert.AreEqual(database.leeUsuario(0).Cuenta, "prenedo");
            Assert.AreEqual(database.leeUsuario("prenedo").IdUsuario, 0);
            Assert.AreSame(database.leeUsuario(5), database.leeUsuario("celizari"));
            Assert.AreEqual(database.leePrueba(0).Nombre, "Prueba psicoténcia empresa A");
            Assert.AreSame(database.leePrueba(0).Evaluador, database.leeUsuario(1));
            Assert.AreEqual(database.leePrueba(0).Evaluador.Rol, Roles.Evaluador);
            Assert.IsFalse(database.leeCalificacion(database.leePrueba(0), database.leeUsuario("aperez")).Calificada);

            //login, logout
            Assert.IsNull(database.UsuarioActual);
            Assert.IsTrue(database.loggin("prenedo"));
            Assert.AreSame(database.UsuarioActual, database.leeUsuario(0));
            database.logout();
            Assert.AreSame(database.UsuarioActual, null);

            //PruebasAspirante, CalificacionesAspirante

            //PruebasEvaluador, CalificacionesPrueba

            //ListarEvaluadores, ListarAspirantes
        }

        [TestMethod]
        public void TestAddDelModUsuario()
        {
        }

        [TestMethod]
        public void TestAddDelModPrueba()
        {
        }

        [TestMethod]
        public void TestAddDelModCalificacion()
        {
        }
    }
}
