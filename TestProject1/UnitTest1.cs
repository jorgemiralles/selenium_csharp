using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {

        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://daktika.com/");
            Driver.FindElement(By.Id("btn-decline-cookies")).Click();
            Driver.FindElement(By.CssSelector(".nav-item:nth-child(2) img")).Click();
            Assert.That(Driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("Do you want your programming students to learn more, better and faster?"));
            Driver.Close();
        }
    }
}