using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using Datos;
using System.IO;
using System.Collections.Generic;

namespace LogicaTest
{
    [TestClass]
    public class DBPruebasTest
    {
        DBPruebas dBPruebas;

        [TestInitialize]
        public void SetupTest()
        {
            dBPruebas = new DBPruebas();
            dBPruebas.cargaDatosIniciales();
        }

        [TestCleanup]
        public void TearDownTest()
        {
            dBPruebas = null;
        }
        [TestMethod]
        public void comprobarContraseñaTest()
        {
            //Correctos por cada rol --> True
            Assert.IsTrue(dBPruebas.comprobarContraseña("prenedo", "prene"));
            Assert.IsTrue(dBPruebas.comprobarContraseña("lalonso", "lau"));
            Assert.IsTrue(dBPruebas.comprobarContraseña("aperez", "passwd3"));
            //Campos vacios --> False
            Assert.IsFalse(dBPruebas.comprobarContraseña("", ""));
            Assert.IsFalse(dBPruebas.comprobarContraseña("", "prene"));
            Assert.IsFalse(dBPruebas.comprobarContraseña("prenedo", ""));
            //Campos nulos --> False
            Assert.IsFalse(dBPruebas.comprobarContraseña(null, null));
            Assert.IsFalse(dBPruebas.comprobarContraseña(null, "prene"));
            Assert.IsFalse(dBPruebas.comprobarContraseña("prenedo", null));
            //Campos incorrectos -->False
            Assert.IsFalse(dBPruebas.comprobarContraseña("prenedo", "lau"));
            Assert.IsFalse(dBPruebas.comprobarContraseña("prenedo", "pepe"));
        }
        [TestMethod]
        public void leeUsuarioTest()
        {

            using (StreamReader reader = new StreamReader(@".\Usuarios.csv"))             {                 String[] user_values;                 while (!reader.EndOfStream)                 {                     user_values = reader.ReadLine().Split(';');                     Usuario user = dBPruebas.leeUsuario(user_values[0]);                     Assert.AreEqual(user_values[1], user.Nombre);
                    Assert.AreEqual(user_values[2], user.Apellidos);                     Assert.AreEqual(user_values[3], user.Rol.ToString());                     Assert.AreEqual(user_values[4], user.EMail);                     Assert.AreEqual(user_values[5], user.Password);                 }             }
        }
        [TestMethod]
        public void añadeUsuarioTest()
        {
            using (StreamReader reader = new StreamReader(@".\AñadeUsuarioTest.csv"))             {                 String[] uv;                 while (!reader.EndOfStream)                 {                     uv = reader.ReadLine().Split(';');                     Assert.AreEqual(uv[6], dBPruebas.añadeUsuario(uv[0], uv[1], uv[2], (Roles)int.Parse(uv[3]), uv[4], uv[5]).ToString());                 }             }
        }
        [TestMethod]
        public void añadePruebaTest()
        {
        }
        [TestMethod]
        public void añadeCalificacionTest()
        {
        }
        [TestMethod]
        public void modificaCalificacionTest()
        {
        }
        [TestMethod]
        public void pruebasAspiranteTest()
        {
        }
        [TestMethod]
        public void calificacionesAspiranteTest()
        {
            List<Calificacion> calificaciones = dBPruebas.calificacionesAspirante("prenedo");
            Assert.AreEqual(0, calificaciones.Count);
            calificaciones = dBPruebas.calificacionesAspirante("lalonso");
            Assert.AreEqual(0, calificaciones.Count);
            calificaciones = dBPruebas.calificacionesAspirante("aperez");
            Assert.AreEqual(3, calificaciones.Count);
            Boolean retorno = true;
            List<Double> calAperez = new List<Double>(new Double[] { 5.5, 8.8});
            foreach (Calificacion c in calificaciones)
            {
                if (c.Calificada && !calAperez.Contains(c.Nota))
                {
                    retorno = false;
                }
                else if (!c.Calificada && c.Nota != 0)
                {
                    retorno = false;
                }
            }
            Assert.IsTrue(retorno);
        }
        [TestMethod]
        public void pruebasEvaluadorTest()
        {
        }
        [TestMethod]
        public void aspirantesPruebaTest()
        {
        }
        [TestMethod]
        public void calificacionesPruebaTest()
        {
        }
        [TestMethod]
        public void listarEvaluadoresTest()
        {
            List<Usuario> expected = new List<Usuario>();
            expected.Add(dBPruebas.leeUsuario("lalonso"));
            expected.Add(dBPruebas.leeUsuario("eblanco"));
            List<Usuario> actual = dBPruebas.listarEvaluadores();
            foreach (Usuario u in expected)
            {
                Assert.IsTrue(actual.Contains(u));
            }
            Assert.AreEqual(2, actual.Count);
        }
        [TestMethod]
        public void listarAspirantesTest()
        {
            List<Usuario> expected = new List<Usuario>();
            expected.Add(dBPruebas.leeUsuario("aperez"));
            expected.Add(dBPruebas.leeUsuario("lalvarez"));
            expected.Add(dBPruebas.leeUsuario("celizari"));
            expected.Add(dBPruebas.leeUsuario("alopez"));
            expected.Add(dBPruebas.leeUsuario("emodron"));
            expected.Add(dBPruebas.leeUsuario("mdelgado"));
            expected.Add(dBPruebas.leeUsuario("omartinez"));
            expected.Add(dBPruebas.leeUsuario("pcuesta"));
            expected.Add(dBPruebas.leeUsuario("crubio"));
            List<Usuario> actual = dBPruebas.listarAspirantes();
            foreach (Usuario u in expected)
            {
                Assert.IsTrue(actual.Contains(u));
            }
            Assert.AreEqual(9, actual.Count);
        }
        [TestMethod]
        public void listarPruebasTest()
        {
            List<Prueba> expected = new List<Prueba>();
            for (int i = 0; i < 5; i++)
            {
                expected.Add(dBPruebas.leePrueba(i));
            }
            List<Prueba> actual = dBPruebas.listarPruebas();
            foreach (Prueba p in expected)
            {
                Assert.IsTrue(actual.Contains(p));
            }
            Assert.AreEqual(5, actual.Count);
        }
    }
}
