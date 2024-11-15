using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AlitaSampleProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            _scenarioContext.Set(driver, "WebDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _scenarioContext.Get<IWebDriver>("WebDriver");
            driver.Quit();
        }
    }
}