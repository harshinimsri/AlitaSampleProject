using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AlitaSampleProject.POM;

namespace AlitaSampleProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private LoginPage _loginPage;

        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _loginPage = new LoginPage(_scenarioContext.Get<IWebDriver>("WebDriver"));
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            _loginPage.EnterCredentials("invalid_user", "invalid_sauce");
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifyLoginSuccess();
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            _loginPage.VerifyLoginFailure();
        }
    }
}