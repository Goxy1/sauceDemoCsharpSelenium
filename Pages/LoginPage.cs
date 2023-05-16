using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class LogInPage:BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public LogInPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public LogInPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By usernameField = By.Id("user-name");
        By passwordField = By.Id("password");
        By loginButton = By.Id("login-button");
        By title = By.ClassName("title");


        /// <summary>
        /// Metoda koja popunjava vrednost u polju username
        /// </summary>
        /// <param name="username"></param>
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje password
        /// </summary>
        /// <param name="password">password</param>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Login
        /// </summary>
        /// <param name="dugmici"></param>
        /// <returns></returns>
        private void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
        }

        /// <summary>
        /// Metoda koja vraca tekst iz title elementa
        /// </summary>
        /// <returns>Vraca true ako postoji na stranici</returns>
        public bool IsLoggedIn()
        {
            return driver.FindElement(title).Displayed;
        }

        /// <summary>
        /// Metoda koja popunjava formu login
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        public void LoginUser(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickOnLoginButton();
        }


    }
}
