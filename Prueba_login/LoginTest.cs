using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Prueba_login
{
    public class Tests
    {

        [Test]
        public void LoginCorrecto()
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.CssSelector("#login > button")).Click();

            driver.Close();
            driver.Quit();

        }
    }
}