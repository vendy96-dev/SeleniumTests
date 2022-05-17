using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
//create new chrome browser instance
var driver = new ChromeDriver();

//navigate to Wikipedia
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("Current Title: " + driver.Title);

//locate search field by Id
var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA"+Keys.Enter);


System.Console.WriteLine("Current Title of searched page: " + driver.Title);
//Close the browser
driver.Quit();
