using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    // Extending custom methods with IWebDriver
    /*public class SeleniumCustomMethods
    {
        public static void Click(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }

        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }

        public static void SubmitButton(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Submit();
        }

        public static void SelectDropDownByText(IWebDriver driver, By locator, string text)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectDropDownByText(IWebDriver driver, By locator, string[] text)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            foreach (string item in text)
            {
                selectElement.SelectByText(item);
            }
        }
    }*/

    // Extending custom methods with IWebElement in Page Object Model
    /*    public class SeleniumCustomMethods
        {
            public static void Click(IWebElement locator)
            {
                locator.Click();
            }

            public static void Submit(IWebElement locator)
            {
                locator.Submit();
            }

            public static void EnterText(IWebElement locator, string text)
            {
                locator.Clear();
                locator.SendKeys(text);
            }

            public static void SelectDropDownByText(IWebElement locator, string text)
            {
                var selectElement = new SelectElement(locator);
                selectElement.SelectByText(text);
            }

            public static void SelectDropDownByValue(IWebElement locator, string value)
            {
                var selectElement = new SelectElement(locator);
                selectElement.SelectByValue(value);
            }

            public static void MultiSelectDropDownByText(IWebElement locator, string[] text)
            {
                var multiSelect = new SelectElement(locator);
                foreach (string item in text)
                {
                    multiSelect.SelectByText(item);
                }
            }

            public static List<string> GetAllSelectedLists(IWebElement locator)
            {
                var options = new List<string>();
                var multiSelect = new SelectElement(locator);

                var selectedOption = multiSelect.AllSelectedOptions;

                foreach (var option in selectedOption)
                {
                    options.Add(option.Text);
                }

                return options;
            }
        }*/

    // Extension methods in Selenium for custom methods
    public static class SeleniumCustomMethods
    {
        public static void ClickElement(this IWebElement locator)
        {
            locator.Click();
        }

        public static void SubmitElement(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(this IWebElement locator, string text)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string value)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectDropDownByText(this IWebElement locator, string[] text)
        {
            var multiSelect = new SelectElement(locator);
            foreach (string item in text)
            {
                multiSelect.SelectByText(item);
            }
        }

        public static List<string> GetAllSelectedLists(this IWebElement locator)
        {
            var options = new List<string>();
            var multiSelect = new SelectElement(locator);

            var selectedOption = multiSelect.AllSelectedOptions;

            foreach (var option in selectedOption)
            {
                options.Add(option.Text);
            }

            return options;
        }
        // Extension methods:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        // Enable you to add methods to existing types without creating a new derived type, recompiling,
        // or otherwise modifying the original type.
        // Extension methods are a special kind of static method, but they are called as if they were
        // instance methods on the extended type.

        // Extension methods rules:
        // - The class that contains the extension method must be static.
        // - The extension method must be static.
    }
}
