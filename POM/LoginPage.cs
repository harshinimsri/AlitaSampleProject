using OpenQA.Selenium;

namespace POM
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(usernameField).SendKeys(username);
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public bool VerifyLoginSuccess()
        {
            return driver.FindElement(By.ClassName("inventory_list")).Displayed;
        }

        public bool VerifyLoginFailure()
        {
            return driver.FindElement(By.ClassName("error-message-container")).Displayed;
        }
    }
}