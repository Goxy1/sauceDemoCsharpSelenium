using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class InventoryPage:BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public InventoryPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public InventoryPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        By cartIcon = By.ClassName("shopping_cart_badge");
        /// <summary>
        /// Metoda koja klikne na zeljeni proizvod
        /// </summary>
        /// <param name="itemName">Ime proizvoda</param>
        public void ClickOnItem(string itemName)
        {
            driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][contains(., '{itemName}')]")).Click();
        }
        private void ClickAddToCartButton()
        {
            ClickOnElement(addToCartButton);
        }
        public string GetCartNumber()
        {
            return GetTextFromElement(cartIcon);
        }
        public void AddItemToCart()
        {
            ClickAddToCartButton();
        }
    }
}
