using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Prueba_login.PageObject;

namespace Prueba_login.Test
{
    public class Tests
    {

        public IWebDriver driver;
        public LoginPage login;

        [SetUp]
        public void IniciarNavegador()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            driver = new ChromeDriver();
            login = new LoginPage(driver);
        }

        [TearDown]

        public void CerrarDrivers()
        {
            driver.Close();
            driver.Quit();
        }
            
        [Test]
        public void LoginCorrecto()
        {
            login.IngresarCredenciales();

            driver.Close();
            driver.Quit();

        }


        [Test]
        public void LoginIncorrecto()
        {
            login.IngresarCredenciales();

            
        }
    }
}