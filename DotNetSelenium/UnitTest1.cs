using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
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
            // create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            // navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // wait for 3 seconds
            Thread.Sleep(3000);

            // maximize the window
            driver.Manage().Window.Maximize();

            // find the search text box
            IWebElement webElement = driver.FindElement(By.Name("q"));

            // type in the search term "Selenium"
            webElement.SendKeys("Selenium");

            //
            webElement.SendKeys(Keys.Enter);
        }
    }
}