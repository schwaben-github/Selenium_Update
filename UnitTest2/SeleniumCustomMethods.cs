using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using System;

namespace UnitTest2
{
    public static class SeleniumCustomMethods
    {
        public static void Click(IWebDriver driver, WebDriverWait wait, By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public static void EnterText(IWebDriver driver, WebDriverWait wait, By locator, string text)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            element.Clear();
            element.SendKeys(text);
        }

        public static void SubmitButton(IWebDriver driver, WebDriverWait wait, By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Submit();
        }

        public static void SelectDropDownByText(IWebDriver driver, WebDriverWait wait, By locator, string text)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(IWebDriver driver, WebDriverWait wait, By locator, string value)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectDropDownByText(IWebDriver driver, WebDriverWait wait, By locator, string[] text)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            SelectElement selectElement = new SelectElement(element);
            foreach (string item in text)
            {
                selectElement.SelectByText(item);
            }
        }
    }
}
