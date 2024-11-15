using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;

namespace AlitaSampleProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void Setup()
        {
            WebUtility webUtility = new WebUtility();
            driver = webUtility.GetDriver();
        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}