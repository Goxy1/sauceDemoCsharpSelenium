using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class AddToCartFromProductPageTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.LoginPage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password
            );

            Pages.InventoryPage.ClickOnItem(TestData.TestData.AddToCart.itemName);
        }

        [Test]
        public void AddToCartFromProductPage()
        {
            Pages.InventoryItemPage.ClickOnAddToCartButton();

            // Assert
            Pages.InventoryItemPage.ClickOnCartButton();
            string itemName = Pages.CartPage.GetItemName();
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, itemName);
        }
    }
}
