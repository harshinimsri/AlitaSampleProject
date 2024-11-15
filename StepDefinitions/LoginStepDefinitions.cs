using NUnit.Framework;
using OpenQA.Selenium;
using POM;

namespace StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage loginPage;

        public LoginStepDefinitions()
        {
            loginPage = new LoginPage(Hooks.Hooks.driver);
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPage.EnterCredentials("invalid_user", "invalid_sauce");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            Assert.IsTrue(loginPage.VerifyLoginSuccess());
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(loginPage.VerifyLoginFailure());
        }
    }
}