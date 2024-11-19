using OpenQA.Selenium;
using TechTalk.SpecFlow;
using YourProject.PageObjects;

namespace YourProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPage.NavigateTo();
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterCredentials(username, password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            Assert.IsTrue(_loginPage.IsDashboardVisible());
        }
    }
}