using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace YourProject.PageObjects
{
    public class Login
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement _usernameField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _passwordField;

        [FindsBy(How = How.Id, Using = "loginButton")]
        private IWebElement _loginButton;

        public Login(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void EnterUsername(string username)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            _usernameField.Clear();
            _usernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            _passwordField.Clear();
            _passwordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _loginButton.Click();
        }

        public bool IsDashboardVisible()
        {
            try
            {
                _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("dashboard")));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}