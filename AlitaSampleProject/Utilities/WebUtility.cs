using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities
{
    public class WebUtility
    {
        private IWebDriver driver;

        public WebUtility()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public void SendKeys(By by, string value)
        {
            FindElement(by).SendKeys(value);
        }

        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void WaitForElementVisible(By by, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public void HandleAlert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
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