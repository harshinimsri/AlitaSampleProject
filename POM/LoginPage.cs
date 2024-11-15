using Utilities;

namespace POM
{
    public class LoginPage
    {
        private WebUtility webUtility;

        public LoginPage(WebUtility utility)
        {
            webUtility = utility;
        }

        public void NavigateToLoginPage()
        {
            webUtility.driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            webUtility.SendKeys("//input[@id='user-name']", username);
            webUtility.SendKeys("//input[@id='password']", password);
        }

        public void ClickLoginButton()
        {
            webUtility.Click("//input[@id='login-button']");
        }

        public bool VerifyLoginSuccess()
        {
            return webUtility.driver.FindElement(By.ClassName("shopping_cart_link")).Displayed;
        }
    }
}