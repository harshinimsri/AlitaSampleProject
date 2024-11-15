using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities
{
    public class WebUtility
    {
        private IWebDriver driver;

        public WebUtility(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Initialize browser
        public void InitializeBrowser()
        {
            // Browser initialization logic here
        }

        // Element waits
        public void WaitForElementVisible(By locator, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        // Alert handling
        public void HandleAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {
                // No alert present
            }
        }

        // Other utility methods can be added here
    }
}