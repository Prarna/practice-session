using PracticeSession.Utilities;
using PracticeSession.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace PracticeSession.Tests
{

    public class LoginTest : BaseTest
    { 
        private LoginPage loginPage = new LoginPage(driver);
        private HomePage homePage = new HomePage(driver);
    
        [Test]
        public void loginInvalidCredentials()
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            loginPage.unsuccessfulLogin("hari", "1223");
            Assert.That(loginPage.verifyLoginErrorMessage, Is.EqualTo("Invalid username or password."));

        }

        [Test]
        public void loginValidCredentials()
        {
            loginPage.successfulLogin("hari", "123123");
            Assert.That(homePage.verify_user_name, Is.EqualTo("Hello hari!"));
        }
    }
}
