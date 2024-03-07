using OpenQA.Selenium;
using PracticeSession.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Pages
{
    public class LoginPage 
    { 
        private readonly IWebDriver driver;

        // Locators
        private readonly By usernameLocator = By.Id("UserName");
        IWebElement usernameField;
        private readonly By passwordLocator = By.Id("Password");
        IWebElement passwordField;
        private readonly By loginButtonLocator = By.XPath("//input[@value = \"Log in\"]");
        IWebElement loginButton;
        private readonly By loginErrorMessageLocator = By.XPath("//li[normalize-space()='Invalid username or password.']");
        IWebElement loginErrorMessage;


        //Created constructor
              
        public LoginPage(IWebDriver driver) {
            this.driver = driver;
        }
        
        public void successfulLogin(string username, string password)
        {
            usernameField = driver.FindElement(usernameLocator);
            usernameField.SendKeys(username);

            passwordField = driver.FindElement(passwordLocator);
            passwordField.SendKeys(password);

        }

        public void unsuccessfulLogin(string username, string password)
        {

            usernameField = driver.FindElement(usernameLocator);
            usernameField.SendKeys(username);

            passwordField = driver.FindElement(passwordLocator);
            passwordField.SendKeys(password);

        }
        public string verifyLoginErrorMessage()
        {
            return loginErrorMessage.Text;
        }
    }
}
