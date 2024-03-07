using OpenQA.Selenium;
using PracticeSession.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Pages
{
    public class HomePage
    { 
        private readonly IWebDriver driver;

        //Locators
        private readonly By userProfileNameLocator =  By.XPath("//*[contains(text(),'Hello hari!')]");
        IWebElement userProfileName;
        private readonly By administrationDropdownLocator = By.XPath("//*[contains(text(),'Administration')]");
        IWebElement administrationDropdown;
        private readonly By timeAndMaterialOptionLocator = By.XPath("//*[contains(text(),'Administration')]");
        IWebElement timeAndMaterialOption;
       

        // Constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void homePageActions() 
        {
            administrationDropdown =  driver.FindElement(administrationDropdownLocator);
            administrationDropdown.Click();
            timeAndMaterialOption = driver.FindElement(timeAndMaterialOptionLocator);
            timeAndMaterialOption.Click();
            
        }
        public string verify_user_name()
        {
           return userProfileName.Text;
            
        }




       
    }
}
