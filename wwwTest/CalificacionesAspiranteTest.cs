﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace wwwTest
{
    [TestClass]
    public class CalificacionesAspiranteTest
    {
        private static Dictionary<Tuple<String, String>, Dictionary<String, String>> aspirantes_Calif;
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [ClassInitialize]
        public static void SetupClass(TestContext testContext)
        {
            aspirantes_Calif = new Dictionary<Tuple<String,String>, Dictionary<String, String>>();
            using (StreamReader reader = new StreamReader(@".\ClalificacionesAspirante.csv"))
            {
                String[] asp_values, p_values;
                while (!reader.EndOfStream)
                {
                    asp_values = reader.ReadLine().Split(';');
                    Tuple<String, String> asp_passwd = Tuple.Create<String, String>(asp_values[0], asp_values[1]);
                    aspirantes_Calif.Add(asp_passwd, new Dictionary<String, String>());
                    for (int i = 0; i < int.Parse(asp_values[2]); i++)
                    {
                        p_values = reader.ReadLine().Split(';');
                        aspirantes_Calif[asp_passwd].Add(p_values[0], p_values[1]);
                    }
                }
            }
        }

        [ClassCleanup]
        public static void TeardownClass()
        {
            aspirantes_Calif = null;
        }

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:63573/Login.aspx";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            driver.Quit();
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void CalificacionesTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            foreach (var asp_passwd in aspirantes_Calif.Keys)
            {
                Assert.AreEqual("Login", driver.FindElement(By.Id("Titulo")).Text);
                driver.FindElement(By.Id("TextBox1")).Clear();
                driver.FindElement(By.Id("TextBox1")).SendKeys(asp_passwd.Item1);
                driver.FindElement(By.Id("TextBox2")).Clear();
                driver.FindElement(By.Id("TextBox2")).SendKeys(asp_passwd.Item2);
                driver.FindElement(By.Id("Button1")).Click();
                Assert.AreEqual("Calificaciones", driver.FindElement(By.Id("Titulo")).Text);
                foreach (String prueba in aspirantes_Calif[asp_passwd].Keys)
                {
                    Assert.IsTrue(IsElementPresent(By.Id("Prueba:"+ prueba)));
                    Assert.AreEqual(aspirantes_Calif[asp_passwd][prueba], driver.FindElement(By.Id("Calificacion:" + prueba)).Text);
                }
                driver.FindElement(By.Id("Cerrar")).Click();
            }
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}