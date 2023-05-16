using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationFramework.Pages
{
    public class BasePage//klasa koja omogucava metode
    {
        // Driver
        public IWebDriver? driver;
        // WebDriverWait
        public WebDriverWait wait;

        /// <summary>
        /// Metoda koja ceka vidljivost elementa
        /// </summary>
        private void WaitForElementToBeVisible(By element)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }

        /// <summary>
        /// Metoda koja klikne na element
        /// </summary>
        public void ClickOnElement(By element)
        {
            WaitForElementToBeVisible(element);
            driver.FindElement(element).Click();
        }
        /// <summary>
        /// Metoda koja upisuje string kroz parametar int
        /// </summary>
        /// <param name="element">element</param>
        /// <param name="number">broj</param>
        public void WriteTextToElement(By element, string text)
        {
            WaitForElementToBeVisible(element);
            driver.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Metoda koja cita text iz elementa
        /// </summary>
        public string ReadTextFromElement(By element)
        {
            WaitForElementToBeVisible(element);
            return driver.FindElement(element).Text;
        }
        public string GetTextFromElement(By element)
        {
            WaitForElementToBeVisible(element);
            return driver.FindElement(element).Text;
        }
    }
}
