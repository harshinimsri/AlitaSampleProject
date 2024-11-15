using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class LoginPage
    {
        private By UsernameField = By.Id("user-name");
        private By PasswordField = By.Id("password");
        private By LoginButton = By.CssSelector("#login-button");
    private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
            _driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public bool VerifyLoginSuccess()
        {
            return _driver.FindElement(By.ClassName("inventory_list")).Displayed;
        }

        public bool VerifyLoginFailure()
        {
            return _driver.FindElement(By.CssSelector("[data-test='error']")).Displayed;
        }
    }
}
private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
            _driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public bool VerifyLoginSuccess()
        {
            return _driver.FindElement(By.ClassName("inventory_list")).Displayed;
        }

        public bool VerifyLoginFailure()
        {
            return _driver.FindElement(By.CssSelector("[data-test='error']")).Displayed;
        }
    }
}
