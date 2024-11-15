using TechTalk.SpecFlow;
using POM;
using Utilities;

[Binding]
public class LoginSteps
{
    private LoginPage loginPage;

    public LoginSteps(WebUtility webUtility)
    {
        loginPage = new LoginPage(webUtility);
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
        loginPage.EnterCredentials("invalid_user", "wrong_sauce");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be logged in successfully")]
    public void ThenIShouldBeLoggedInSuccessfully()
    {
        Assert.IsTrue(loginPage.VerifyLoginSuccess());
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsFalse(loginPage.VerifyLoginSuccess());
    }
}