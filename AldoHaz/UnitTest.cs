using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AldoHaz
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx?AspxAutoDetectCookieSupport=1";
            ChromeDriver chrdrv = new ChromeDriver();
            chrdrv.Navigate().GoToUrl(url);
            chrdrv.Manage().Window.Maximize();
            chrdrv.FindElement(By.Id("LoginUser_UserName")).SendKeys("demo");
            chrdrv.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");
            chrdrv.FindElement(By.Name("LoginUser$LoginButton")).Click();
            Thread.Sleep(2000);
            chrdrv.FindElement(By.Id("liClientes")).Click();
            Thread.Sleep(3000);
            chrdrv.FindElement(By.Id("MainContent_btnAdd")).Click();
            Thread.Sleep(5000);
            chrdrv.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("AldoHaz");
            var chrdrvIdentidad = chrdrv.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var elem = new SelectElement(chrdrvIdentidad);
            elem.SelectByText("Cédula");
            Thread.Sleep(3000);
            chrdrv.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0915272116");
            chrdrv.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("5016948");
            chrdrv.FindElement(By.Id("MainContent_txtExtension")).SendKeys("1018");
            chrdrv.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0992795517");
            chrdrv.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Alborada");
            chrdrv.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("aldo.haz@gmail.com");
            chrdrv.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("aldo.haz.poke@gmail.com");
            chrdrv.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
            Thread.Sleep(5000);
            chrdrv.SwitchTo().Alert().Accept();
        }
    }
}
