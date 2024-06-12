using OpenQA.Selenium;

namespace DotNetSelenium.Pages
{
    internal class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));

        IWebElement TxtUserName => driver.FindElement(By.Id("UserName"));

        IWebElement TxtPassword => driver.FindElement(By.Id("Password"));

        IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));


        public void ClickLogin()
        {
            LoginLink.ClickElement();
        }

        public void Login(string username, string password)
        {
            TxtUserName.EnterText(username);
            TxtPassword.EnterText(password);
            BtnLogin.SubmitElement();
        }
    }
}
