// New Execute Automation YouTube Playlist

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using DotNetSelenium.Pages;

namespace DotNetSelenium
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            
        }

        /*[Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Website open");

            // wait for 3 seconds
            Thread.Sleep(3000);
            Console.WriteLine("Manually closing the cookies consent pop-up");

            // maximize the window
            driver.Manage().Window.Maximize();
            Console.WriteLine("Window maximize");

            // find the search text box
            IWebElement webElement = driver.FindElement(By.Name("q"));

            // type in the search term "Selenium"
            webElement.SendKeys("Selenium");

            // click the search button
            webElement.SendKeys(Keys.Enter);
            Console.WriteLine("Search executed");

            // wait for 3 seconds
            Thread.Sleep(3000);

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }*/

        [Test, Order(1)]
        public void EAWebsiteTest()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.eaapp.somee.com");
            Console.WriteLine("Website open");

            // wait for 3 seconds
            Thread.Sleep(3000);

            // maximize the window
            driver.Manage().Window.Maximize();
            Console.WriteLine("Window maximize");

            // find the login link
            IWebElement loginLink = driver.FindElement(By.Id("loginLink"));

            // click the login link
            loginLink.Click();
            Console.WriteLine("Login link clicked");

            // find the username text box
            IWebElement txtUserName = driver.FindElement(By.Id("UserName"));

            // type in the username
            txtUserName.SendKeys("admin");
            Console.WriteLine("User name entered");

            // find the password text box
            IWebElement txtPassword = driver.FindElement(By.Id("Password"));

            // type in the password
            txtPassword.SendKeys("password");
            Console.WriteLine("Password entered");

            // find the login button
            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));

            // click the login button
            btnLogin.Submit();
            Console.WriteLine("Login button submitted");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(2)]
        public void EAWebsiteTestReducedSize()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.eaapp.somee.com");
            Console.WriteLine("Website open");

            // find and click the login link
            driver.FindElement(By.Id("loginLink")).Click();
            Console.WriteLine("Login link located and clicked");

            // find and fill the username text box
            driver.FindElement(By.Id("UserName")).SendKeys("admin");
            Console.WriteLine("User name box located and filled");

            // find and fill the password text box
            driver.FindElement(By.Id("Password")).SendKeys("password");
            Console.WriteLine("Password box located and filled");

            // find and submit the login button
            driver.FindElement(By.CssSelector(".btn")).Submit();
            Console.WriteLine("Login button located and submitted");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(3)]
        public void WorkingWithAdvancedControls()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            Console.WriteLine("Website open");

            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("dropdown")));
            selectElement.SelectByText("Option 2");
            Console.WriteLine("Dropdown option selected");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(4)]
        public void WorkingWithAdvancedControls2()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("multi-select")));
            multiSelect.SelectByValue("Florida");
            multiSelect.SelectByValue("Ohio");
            multiSelect.SelectByValue("Washington");
            Console.WriteLine("Multi-select values Florida, Ohio and Washington selected");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(5)]
        public void WorkingWithAdvancedControls3()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("multi-select")));
            multiSelect.SelectByValue("Florida");
            multiSelect.SelectByValue("Ohio");
            multiSelect.SelectByValue("Washington");
            Console.WriteLine("Multi-select values Florida, Ohio and Washington selected");

            // deselect Ohio
            multiSelect.DeselectByValue("Ohio");
            Console.WriteLine("Ohio deselected");

            IList<IWebElement> selectedOptions = multiSelect.AllSelectedOptions;
            foreach (IWebElement option in selectedOptions)
            {
                Console.WriteLine("Selected option: " + option.Text);
            }

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(6)]
        public void UsingCustomMethods()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.eaapp.somee.com");
            Console.WriteLine("Website open");

            /*// wait for 3 seconds
            Thread.Sleep(1000);

            // maximize the window
            driver.Manage().Window.Maximize();
            Console.WriteLine("Window maximize");*/

            // NEW: click method!
            SeleniumCustomMethods.Click(driver, By.Id("loginLink"));
            Console.WriteLine("Login link located and clicked");

            // NEW: enter username!
            SeleniumCustomMethods.EnterText(driver, By.Id("UserName"), "admin");
            Console.WriteLine("User name box located and filled");

            // NEW: enter password!
            SeleniumCustomMethods.EnterText(driver, By.Id("Password"), "password");
            Console.WriteLine("Password box located and filled");

            // NEW: submit button!
            SeleniumCustomMethods.SubmitButton(driver, By.CssSelector(".btn"));
            Console.WriteLine("Login button located and submitted");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(7)]
        public void UsingCustomMethods2()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            Console.WriteLine("Website open");

            // NEW: using custom method!
            SeleniumCustomMethods.SelectDropDownByText(driver, By.Id("dropdown"), "Option 2");
            Console.WriteLine("Dropdown option selected");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        [Test, Order(8)]
        public void UsingCustomMethods3()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            // NEW: using custom method!
            SeleniumCustomMethods.MultiSelectDropDownByText(driver, By.Id("multi-select"), new string[] { "Florida", "Ohio", "Washington" });
            Console.WriteLine("Multi-select values Florida, Ohio and Washington selected");

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");
        }

        // Page Object Model
        [Test, Order(9)]
        public void UsingPageObjectModel()
        {
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.eaapp.somee.com");
            Console.WriteLine("Website open using POM");

            // NEW: using page object model!
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            Console.WriteLine("Login link located and clicked");

            // NEW: using page object model!
            loginPage.Login("admin", "password");
            Console.WriteLine("User name and password entered");
            Console.WriteLine("Login button located and submitted");

            // Wait for 3 seconds before closing the browser
            Thread.Sleep(3000);

            // close the browser
            driver.Close();
            Console.WriteLine("Browser window closed!");// close the browser
        }
    }
}