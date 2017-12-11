using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace LogicaTest
{
    /// <summary>
    /// Descripción resumida de DBPruebasTest
    /// </summary>
    [TestClass]
    public class DBPruebasTest
    {
        private ICapaDatos dbPrueba;

        [TestInitialize]
        public void inicializar()
        {
            dbPrueba = new DBPruebas();
        }

        [TestMethod]
        public void TestCargaDatosIniciales()
        {
            Assert.IsTrue(dbPrueba.cargaDatosIniciales());
            Assert.AreEqual(dbPrueba.listarEvaluadores().Count, 2);
            Assert.AreEqual(dbPrueba.listarAspirantes().Count, 9);
            Assert.AreEqual(dbPrueba.listarPruebas().Count, 5);
            Assert.AreEqual(dbPrueba.pruebasAspirante("aperez").Count, 3);
        }

        [TestMethod]
        public void TestcomprobarContraseña()
        {
            Assert.IsTrue(dbPrueba.comprobarContraseña("lalonso", "lau"));
            Assert.IsFalse(dbPrueba.comprobarContraseña("prenedo", "lau"));
            Assert.IsFalse(dbPrueba.comprobarContraseña("Pepe", "lau"));
        }

        [TestMethod]
        public void TestleeUsuario()
        {
            Assert.AreEqual(dbPrueba.leeUsuario("prenedo").Cuenta, "prenedo");
        }

        [TestMethod]
        public void TestañadeUsuario()
        {
            dbPrueba.cargaDatosIniciales();
            Assert.IsFalse(dbPrueba.añadeUsuario("crubio", "Consuelo", "Rubio Abad", Datos.Roles.Aspirante, "c.rubio@aspirante.es", "passwd11"));
            Assert.AreEqual(dbPrueba.listarAspirantes().Count, 9);
            Assert.IsTrue(dbPrueba.añadeUsuario("pPrueba", "Prueba", "prueba", Datos.Roles.Administrador, "prueba.prueba@administrador.es", "prene"));
            Assert.AreEqual(dbPrueba.listarAspirantes().Count, 10);
        }

        [TestMethod]
        public void TestAñadePrueba()
        {
            dbPrueba.cargaDatosIniciales();
            Assert.AreEqual(dbPrueba.listarPruebas().Count, 5);
            Assert.IsFalse(dbPrueba.añadePrueba("Prueba psicoténcia empresa A", "lalonso"));//Ya existe
            Assert.IsFalse(dbPrueba.añadePrueba("Prueba psicoténcia empresa A", null));//Evaluador no puede ser null
            Assert.IsFalse(dbPrueba.añadePrueba(null, "lalonso"));//Prueba no puede ser null
            Assert.IsFalse(dbPrueba.añadePrueba("", "lalonso"));//Prueba no puede ser ""
            Assert.IsFalse(dbPrueba.añadePrueba("Prueba", "prenedo"));//Administrador no puede evaluar
            Assert.IsFalse(dbPrueba.añadePrueba("Prueba", "aperez"));//Aspirante no puede evaluar
            Assert.IsTrue(dbPrueba.añadePrueba("Prueba", "aperez"));
            Assert.AreEqual(dbPrueba.listarPruebas().Count, 6);
        }

        [TestMethod]
        public void TestAñadeCalificacion()
        {
            //Assert.IsFalse(dbPrueba.añadeCalificacion(null, "aperez"));//Prueba no puede ser null
            Assert.IsFalse(dbPrueba.añadeCalificacion(0, null));//Aspirante no puede ser null
            Assert.IsFalse(dbPrueba.añadeCalificacion(10, "aperez"));//Prueba no existe
            Assert.IsFalse(dbPrueba.añadeCalificacion(0, ""));//Aspirante no existe
            Assert.IsFalse(dbPrueba.añadeCalificacion(0, "prenedo"));//Aspirante no puede ser administrador
            Assert.IsFalse(dbPrueba.añadeCalificacion(0, "lalonso"));//Aspirante no puede ser evaluador
            Assert.IsTrue(dbPrueba.añadeCalificacion(0, "aperez"));//Aspirante no puede ser evaluador
        }
    }
}
