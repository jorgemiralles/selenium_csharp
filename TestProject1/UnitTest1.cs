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
        public void RegisterBtnEs()
        {
            driver.Navigate().GoToUrl("https://daktika.com/");
            driver.FindElement(By.Id("btn-decline-cookies")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".btn-info")).Text, Is.EqualTo("REGISTRO DEL ESTUDIANTE"));
            driver.Close();
        }

        [Test]
        public void HomeDesktopEn()
        {
            driver.Navigate().GoToUrl("https://daktika.com/");
            driver.FindElement(By.Id("btn-decline-cookies")).Click();
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) img")).Click();
            Assert.That(driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("Do you want your programming students to learn more, better and faster?"));
            driver.Close();
        }

        [Test]
        public void TypeScriptEnExercises()
        {
            driver.Navigate().GoToUrl("https://daktika.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
            driver.FindElement(By.Id("btn-decline-cookies")).Click();
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) img")).Click();
            driver.FindElement(By.LinkText("/ Exercises")).Click();
            driver.FindElement(By.CssSelector("input")).Click();
            driver.FindElement(By.CssSelector("input")).SendKeys("1 to");
            driver.Close();
        }
    }
}