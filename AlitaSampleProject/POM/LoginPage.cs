using OpenQA.Selenium;
using Utilities;

namespace POM
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By UsernameField = By.Id("user-name");
        private By PasswordField = By.Id("password");
        private By LoginButton = By.CssSelector("#login-button");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToLoginPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(UsernameField).SendKeys(username);
            driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public bool VerifyLoginSuccess()
        {
            // Assuming there's a unique element that appears only upon successful login
            By successIndicator = By.CssSelector(".success_message");
            try
            {
                return driver.FindElement(successIndicator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
