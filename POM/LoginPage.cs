using OpenQA.Selenium;
using Utilities;

namespace POM
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebUtility webUtility;

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
            webUtility = new WebUtility(driver);
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void LocateElements()
        {
            IWebElement usernameField = driver.FindElement(By.Id("user-name"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
        }

        public void EnterCredentials(string username, string password)
        {
            LocateElements();
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        public bool VerifyLoginSuccess()
        {
            // Verification logic here
            return true; // Placeholder
        }
    }
}