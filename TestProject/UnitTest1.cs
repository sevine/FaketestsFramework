using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver browser = new ChromeDriver();

            browser.Navigate().GoToUrl("https://www.dating.com/");
            string etalonSlogan = "Your World. Your Love.";


            string realSlogan = browser.FindElement(By.CssSelector("h1  l10n")).Text;

            Assert.That(browser.Title, Does.Contain("Dating"), "Кривой title");
            Assert.That(etalonSlogan, Is.EqualTo(realSlogan), "Кривой слоган");

        }

      
    }
}