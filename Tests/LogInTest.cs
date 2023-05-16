using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class LogInTest:BaseTest
    {
        [Test]
        public void LoginUser()
        {
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username,
                TestData.TestData.LoginTest.password
            );

            // Asert testa
            Assert.IsTrue(Pages.LoginPage.IsLoggedIn());
        }


    }
}
