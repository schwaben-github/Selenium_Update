// Modified to open a new tab in the same window and switch to it for every test method
// Modified to use the Login method to log in before starting the test, if not already logged in
// Therefore two of the previous test methods have been combined into one

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers; // Add this line
using NUnit.Framework;
using System;

namespace UnitTest2
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private bool isLoggedIn = false;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        private void OpenNewTab(string url)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles[driver.WindowHandles.Count - 1]);
            driver.Navigate().GoToUrl(url);
        }

        private void Login()
        {
            // If already logged in, skip the login process
            if (isLoggedIn)
            {
                Console.WriteLine("User is already logged in.");
                return;
            }

            OpenNewTab("http://www.eaapp.somee.com");
            Console.WriteLine("Website open");

            // Wait for the login link to be clickable and then click it
            IWebElement loginLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("loginLink")));
            loginLink.Click();
            Console.WriteLine("Login link clicked");

            // Find the username text box and type in the username
            IWebElement txtUserName = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("UserName")));
            txtUserName.SendKeys("admin");
            Console.WriteLine("User name entered");

            // Find the password text box and type in the password
            SeleniumCustomMethods.EnterText(driver, wait, By.Id("Password"), "password");
            Console.WriteLine("Password box located and filled");

            // Find the login button and submit
            SeleniumCustomMethods.SubmitButton(driver, wait, By.CssSelector(".btn"));
            Console.WriteLine("Login button located and submitted");

            isLoggedIn = true; // Set the login flag to true
        }

        [Test, Order(1)]
        public void EAWebsiteTestReducedSize()
        {
            // Login before starting the test
            Login();
            // Continue with the test steps
        }

        [Test, Order(2)]
        public void WorkingWithAdvancedControls()
        {
            OpenNewTab("https://the-internet.herokuapp.com/dropdown");
            Console.WriteLine("Website open");

            SelectElement selectElement = new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdown"))));
            selectElement.SelectByText("Option 2");
            Console.WriteLine("Dropdown option selected");
        }

        [Test, Order(3)]
        public void WorkingWithAdvancedControls2()
        {
            OpenNewTab("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            SelectElement multiSelect = new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("multi-select"))));
            multiSelect.SelectByValue("Florida");
            multiSelect.SelectByValue("Ohio");
            multiSelect.SelectByValue("Washington");
            Console.WriteLine("Multi-select values Florida, Ohio, and Washington selected");
        }

        [Test, Order(4)]
        public void WorkingWithAdvancedControls3()
        {
            OpenNewTab("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            SelectElement multiSelect = new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("multi-select"))));
            multiSelect.SelectByValue("Florida");
            multiSelect.SelectByValue("Ohio");
            multiSelect.SelectByValue("Washington");
            Console.WriteLine("Multi-select values Florida, Ohio, and Washington selected");

            // Deselect Ohio
            multiSelect.DeselectByValue("Ohio");
            Console.WriteLine("Ohio deselected");

            IList<IWebElement> selectedOptions = multiSelect.AllSelectedOptions;
            foreach (IWebElement option in selectedOptions)
            {
                Console.WriteLine("Selected option: " + option.Text);
            }
        }

        [Test, Order(5)]
        public void UsingCustomMethods2()
        {
            OpenNewTab("https://the-internet.herokuapp.com/dropdown");
            Console.WriteLine("Website open");

            SeleniumCustomMethods.SelectDropDownByText(driver, wait, By.Id("dropdown"), "Option 2");
            Console.WriteLine("Dropdown option selected");
        }

        [Test, Order(6)]
        public void UsingCustomMethods3()
        {
            OpenNewTab("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            Console.WriteLine("Website open");

            SeleniumCustomMethods.MultiSelectDropDownByText(driver, wait, By.Id("multi-select"), new string[] { "Florida", "Ohio", "Washington" });
            Console.WriteLine("Multi-select values Florida, Ohio, and Washington selected");
        }
    }
}