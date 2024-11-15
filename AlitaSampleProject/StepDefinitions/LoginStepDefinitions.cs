using TechTalk.SpecFlow;
using POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;
    private LoginPage loginPage;

    public LoginStepDefinitions()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
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
        bool result = loginPage.VerifyLoginSuccess();
        Assert.IsTrue(result);
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        bool result = loginPage.VerifyLoginSuccess();
        Assert.IsFalse(result);
    }
}