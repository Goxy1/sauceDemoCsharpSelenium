﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class CartIconTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Login user
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username,
                TestData.TestData.LoginTest.password
            );
        }

        [Test]
        public void ValidateCartIconCounter()
        {
            // Add all products to the cart
            Pages.InventoryPage.ClickOnAllAddToCartButtons();
            string cartNumber = Pages.InventoryPage.GetCartNumber(); // Broj u korpi nakon klikova na dugme add to cart
            // Remove one item from cart
            Pages.InventoryPage.ClickOnRemoveButton();
            string cartNumberAfterDelete = Pages.InventoryPage.GetCartNumber(); // broj u korpi nakon brisanja jednog proizvoda

            // Assert test - Provera da li su dva broja iz korpe razlicita posle brisanja
            // jednog proizvoda iz korpe
            Assert.AreNotEqual(cartNumber, cartNumberAfterDelete);
        }
    }
}
