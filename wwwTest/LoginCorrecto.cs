using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class LoginCorrecto
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
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
        public void TheLoginEvaluadorCorrectoTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            driver.FindElement(By.Id("TextBox1")).Clear();
            driver.FindElement(By.Id("TextBox1")).SendKeys("lalonso");
            driver.FindElement(By.Id("TextBox2")).Clear();
            driver.FindElement(By.Id("TextBox2")).SendKeys("lau");
            driver.FindElement(By.Id("Button1")).Click();
            Assert.AreEqual("Calificar prueba", driver.FindElement(By.Id("Titulo")).Text);
        }

        [TestMethod]
        public void TheLoginAspiranteCorrectoTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            driver.FindElement(By.Id("TextBox1")).Clear();
            driver.FindElement(By.Id("TextBox1")).SendKeys("aperez");
            driver.FindElement(By.Id("TextBox2")).Clear();
            driver.FindElement(By.Id("TextBox2")).SendKeys("passwd3");
            driver.FindElement(By.Id("Button1")).Click();
            Assert.AreEqual("Calificaciones", driver.FindElement(By.Id("Titulo")).Text);
        }

        [TestMethod]
        public void TheLoginAdminCorrectoTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            driver.FindElement(By.Id("TextBox1")).Clear();
            driver.FindElement(By.Id("TextBox1")).SendKeys("aperez");
            driver.FindElement(By.Id("TextBox2")).Clear();
            driver.FindElement(By.Id("TextBox2")).SendKeys("passwd3");
            driver.FindElement(By.Id("Button1")).Click();
            Assert.AreEqual("Calificaciones", driver.FindElement(By.Id("Titulo")).Text);
        }
    }
}
