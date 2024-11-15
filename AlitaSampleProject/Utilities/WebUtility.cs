using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class WebUtility
    {
        private IWebDriver driver;

        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebElement WaitForElementToBeVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitForElementToBeClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void ClickElement(By locator)
        {
            WaitForElementToBeClickable(locator).Click();
        }

        public void SendKeysToElement(By locator, string text)
        {
            WaitForElementToBeVisible(locator).SendKeys(text);
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void HandleAlert()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent()).Accept();
        }

        public void QuitBrowser()
        {
            driver.Quit();
        }
    }
}
