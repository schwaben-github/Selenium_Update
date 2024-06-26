// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]
public class CreateUserTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  
    [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  
    [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  
    [Test]
  public void createUser() {
    driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1050, 798);
    driver.FindElement(By.Id("loginLink")).Click();
    driver.FindElement(By.Id("UserName")).Click();
    driver.FindElement(By.Id("UserName")).Click();
    driver.FindElement(By.Id("UserName")).Click();
    {
      var element = driver.FindElement(By.Id("UserName"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("UserName")).SendKeys("admin");
    driver.FindElement(By.Id("Password")).SendKeys("password");
    driver.FindElement(By.CssSelector(".btn")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".btn"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.LinkText("Employee List")).Click();
    driver.FindElement(By.LinkText("Create New")).Click();
    driver.FindElement(By.Id("Name")).Click();
    driver.FindElement(By.Id("Name")).SendKeys("Recorded User");
    driver.FindElement(By.Id("Salary")).SendKeys("10000");
    driver.FindElement(By.Id("DurationWorked")).SendKeys("10");
    driver.FindElement(By.Id("Grade")).Click();
    {
      var dropdown = driver.FindElement(By.Id("Grade"));
      dropdown.FindElement(By.XPath("//option[. = 'Senior']")).Click();
    }
    driver.FindElement(By.CssSelector(".form-horizontal")).Click();
    driver.FindElement(By.Id("Email")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("recorded.user@gmail.com");
    driver.FindElement(By.CssSelector(".btn")).Click();
  }
}
