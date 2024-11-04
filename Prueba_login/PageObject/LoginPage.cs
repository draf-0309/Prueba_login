using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_login.PageObject
{
    internal class LoginPage
    {
        public IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private readonly By _txtUsername = By.Id("username");
        private readonly By _txtPassword = By.Id("password");
        private readonly By _btnLogin = By.CssSelector("#login > button");

        public IWebElement username => _driver.FindElement(_txtUsername);
        public IWebElement password => _driver.FindElement(_txtPassword);
        public IWebElement btnLogin => _driver.FindElement(_btnLogin);

        public void IngresarNombre()
        {
            username.SendKeys("tomsmith");
        }

        public void IngresarCredenciales()
        {
            username.SendKeys("tomsmith");
            password.SendKeys("SuperSecretPassword!");
            btnLogin.Click();
        }


    }
}
