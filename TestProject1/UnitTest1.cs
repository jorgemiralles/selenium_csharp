using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--headless");
            driver = new ChromeDriver(option);

        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://daktika.com/");
            driver.FindElement(By.Id("btn-decline-cookies")).Click();
            Assert.That(driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("¿Quieres que tus alumnos de programación aprendan más, mejor y más rápido?"));
            var elements = driver.FindElements(By.CssSelector("h2"));
            Assert.True(elements.Count > 0);
            driver.Close();


            //Driver.FindElement(By.CssSelector(".nav-item:nth-child(2) img")).Click();
            //Assert.That(Driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("Do you want your programming students to learn more, better and faster?"));
            //Driver.Close();
        }
    }
}