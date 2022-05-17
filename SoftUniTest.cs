using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitWebDriverTests
{
    public class SoftUniTests
    {
        private WebDriver driver;
        [OneTimeSetUp]
        public void OpenBrowserAndNavigateToPage()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://softuni.bg";
            driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            this.driver.Quit();
        }

        [Test]
        public void Test_MainPageTitle()
            
        {
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";
            //Assert
            Assert.AreEqual(expectedTitle,driver.Title);
        }


        [Test]
        public void Test_ClickOnAboutUsPage()
        {
            var buttonForUs = driver.FindElement(By.CssSelector("#header-nav .nav-item>.nav-link .cell"));
            buttonForUs.Click();
            string expectedTitle = "За нас - Софтуерен университет";
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
        }
    }
}