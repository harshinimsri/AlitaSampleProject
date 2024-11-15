using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    using OpenQA.Selenium;
using Utilities;

namespace POM
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebUtility webUtility;
        private By UsernameField = By.Id("user-name");
        private By PasswordField = By.Id("password");
        private By LoginButton = By.CssSelector("#login-button");
        private By LoginSuccessIndicator = By.CssSelector(".title");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            webUtility = new WebUtility(driver);
        }

        public void NavigateToLoginPage()
        {
            webUtility.NavigateTo("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            webUtility.SendKeysToElement(UsernameField, username);
            webUtility.SendKeysToElement(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            webUtility.ClickElement(LoginButton);
        }

        public bool VerifyLoginSuccess()
        {
            return webUtility.WaitForElementToBeVisible(LoginSuccessIndicator).Displayed;
        }
    }
}
}
