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
            Assert.That(driver.FindElement(By.CssSelector(".btn-info")).Text, Is.EqualTo("REGISTRO DEL ESTUDIANT"));
            driver.Close();
        }
    }
}