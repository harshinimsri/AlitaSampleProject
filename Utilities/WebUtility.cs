using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities
{
    public class WebUtility
    {
        public IWebDriver driver;

        public WebUtility(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void InitializeBrowser()
        {
            // Initialize browser settings
        }

        public void SendKeys(string xpath, string value)
        {
            var element = driver.FindElement(By.XPath(xpath));
            element.SendKeys(value);
        }

        public void Click(string xpath)
        {
            var element = driver.FindElement(By.XPath(xpath));
            element.Click();
        }

        public void WaitUntilElementIsVisible(string xpath, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        public void HandleAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {
                // No alert to handle
            }
        }

        public void Quit()
        {
            driver.Quit();
        }
    }
}