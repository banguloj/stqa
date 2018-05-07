using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STQA
{
    class Tweeter
    {
        ChromeDriver Chrome;
        [SetUp]

        public void StartBrowser()
        {
            Chrome = new ChromeDriver();
            Chrome.Manage().Window.Maximize();
            Chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void Login()
        {
            try
            {
                string Email = "banguloj@gamil.com";
                String Password = "azuloscuro1980";

                Console.WriteLine("Navegando a https://twitter.com/login");
                Chrome.Navigate().GoToUrl("https://twitter.com/login");

                Console.WriteLine("Escribiendo el email:" + Email);
                IWebElement EmailElement = Chrome.FindElement(By.XPath("//*[@id='page - container']/div/div[1]/form/fieldset/div[1]/input"));
                EmailElement.SendKeys(Email);

                Console.WriteLine("Escribiendo contraseña" + Password);
                IWebElement PasswordElement = Chrome.FindElement(By.XPath("//*[@id='page - container']/div/div[1]/form/fieldset/div[2]/input"));
                PasswordElement.SendKeys(Password);
                IWebElement SubmitElement = Chrome.FindElement(By.XPath("//*[@id='page - container']/div/div[1]/form/div[2]/button"));
                SubmitElement.Click();
            }

            catch (Exception)

            {
                Console.WriteLine("Ha ocurrido un error");
            }
        }

    }
}
