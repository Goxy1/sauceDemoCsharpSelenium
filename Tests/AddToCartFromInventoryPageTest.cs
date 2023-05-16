using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class AddToCartFromInventoryPageTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.LoginPage.Login(
                TestData.TestData.Login.username,
                TestData.TestData.Login.password);
        }
        [Test]
        public void AddToCartFromInventoryPage()
        {
            Pages.InventoryItemPage.ClickOnAddToCartButton();

            // Assert

            string cartNumber = Pages.InventoryPage.GetCartNumber();
            
            Assert.AreEqual("1",cartNumber);
            
            Pages.InventoryItemPage.ClickOnCartButton();
            string itemName = Pages.CartPage.GetItemName();
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, itemName);
        }
    }
}
