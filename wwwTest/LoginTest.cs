using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace SeleniumTests
{
    [TestClass]
    public class LoginTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        
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
        public void TheLoginTestMethod()
        {
            using (var reader = new StreamReader(@"./LoginTest.csv"))
            {
                while(!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
                    driver.FindElement(By.Id("TextBox1")).Clear();
                    driver.FindElement(By.Id("TextBox1")).SendKeys(values[0]);
                    driver.FindElement(By.Id("TextBox2")).Clear();
                    driver.FindElement(By.Id("TextBox2")).SendKeys(values[1]);
                    driver.FindElement(By.Id("Button1")).Click();
                    Assert.AreEqual(values[2], driver.FindElement(By.Id("Titulo")).Text);
                }
            }
        }
    }
}
