using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataDrivenTestsDemo
{
    public class WebDriverCalculatorTests
    {
        private ChromeDriver driver;
        [SetUp]
        public void OpenAndNavigate()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Url = "https://number-calculator.nakov.repl.co/";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
            
        }

        [Test]
        public void TestCalculator()
        {
            //Arrange
            var field1 = driver.FindElement(By.Id("number1"));
            var operationSign = driver.FindElement(By.Id("operation"));
            var field2 = driver.FindElement(By.Id("number2"));
            var calcButton = driver.FindElement(By.Id("calcButton"));
            var resultField = driver.FindElement(By.Id("result"));
            var resultButton = driver.FindElement(By.Id("resetButton"));

            //Act
            field1.SendKeys("5");
            operationSign.SendKeys("+ (sum)");
            field2.SendKeys("6");
            calcButton.Click();
            string expectedValue = "Result: 11";

            //Assert
            Assert.That(expectedValue, Is.EqualTo(resultField.Text));

        }
    }
}