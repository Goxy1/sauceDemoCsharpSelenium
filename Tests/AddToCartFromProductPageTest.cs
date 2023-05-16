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
            // Login user
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username,
                TestData.TestData.LoginTest.password
            );

            // Click on product
            Pages.InventoryPage.ClickOnItem(TestData.TestData.AddToCart.itemName);
        }

        [Test]
        public void AddToCartFromProductPage()
        {
            // Click to add to cart
            Pages.InventoryItemPage.ClickOnAddToCartButton();

            // Assert - Provera da li je dodat proizvod u korpu
            Pages.InventoryItemPage.ClickOnCartButton();
            string itemName = Pages.CartPage.GetItemName();
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, itemName);
        }
    }
}
