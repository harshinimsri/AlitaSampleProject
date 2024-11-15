using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;

namespace AlitaSampleProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;
        private WebUtility webUtility;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtility = new WebUtility();
            webUtility.InitializeBrowser();
            driver = webUtility.GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtility.QuitBrowser();
        }
    }
}