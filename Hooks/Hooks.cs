using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Utilities;

[Binding]
public class Hooks
{
    private IWebDriver driver;
    private WebUtility webUtility;

    [BeforeScenario]
    public void BeforeScenario()
    {
        driver = new ChromeDriver();
        webUtility = new WebUtility(driver);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        webUtility.Quit();
    }
}