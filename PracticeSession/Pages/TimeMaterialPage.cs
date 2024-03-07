using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticeSession.Utilities;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Pages
{
    public class TimeMaterialPage
    {
        private IWebDriver driver;

        // Locator
        private readonly By createNewButtonLocator = By.XPath("//a[contains(text(), 'Create New')]");
        IWebElement createNewButton;
        private readonly By typeCodeMainDropdownLocator = By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span");
        IWebElement typeCodeMainDropdown;
        private readonly By typeCodeDropdownLocator = By.XPath("//span[@class='k-input']");
        IWebElement typeCodedropdown;
        private readonly By codeTextboxLocator = By.Id("Code");
        IWebElement codeTextbox;
        private readonly By descriptionTextboxLocator = By.Id("Description");
        IWebElement descriptionTextbox;
        private readonly By priceTextboxLocator = By.XPath("//input[@class= 'k-formatted-value k-input']");
        IWebElement priceTextbox;
        private readonly By saveButtonLocator = By.Id("SaveButton");
        IWebElement saveButton;
        private readonly By goToLastpageButtonLocator = By.XPath("//div[@id='tmsGrid']//a[@title='Go to the last page']");
        private IWebElement goToLastpageButton;
        private readonly By editNewlyCreatedRecordLocator = By.XPath("//a[@class='k-button k-button-icontext k-grid-Edit'][normalize-space()='Edit'][//td[normalize-space()='Material2024']]");
        private IWebElement editNewlyCreatedRecord;
        private readonly By deleteNewlyCreatedRecordLocator = By.XPath("//a[@class='k-button k-button-icontext k-grid-Delete'][normalize-space()='Delete'][//td[normalize-space()='Material2024']]");
        private IWebElement deleteNewlyCreatedRecord;
        private readonly By recordTableHeaderLocator = By.XPath("//div[@class='k-grouping-header' and text()='Drag a column header and drop it here to group by that column']");
        IWebElement recordTableHeader;
        private readonly By createdRecordLocator = By.XPath("//td[normalize-space()='Material2024']");
        private IWebElement createdRecord;


        // Constructor
        public TimeMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Page Methods
        public void IsCreateNewButtonVisible()
        {
            //return createNewButton.Text;
          WaitUtils.WaitToBeVisible(driver, createNewButtonLocator);

          //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMicroseconds(30));
           //IWebElement createNewButton= wait.Until(ExpectedConditions.ElementIsVisible((By)driver.FindElement(createNewButtonLocator)));
        }
        public void CreateTimeMaterialRecord(string code, string description, string price)
        {
            createNewButton = driver.FindElement(createNewButtonLocator);
            createNewButton.Click();

            typeCodeMainDropdown = driver.FindElement(typeCodeMainDropdownLocator);
            typeCodeMainDropdown.Click();

            typeCodedropdown = driver.FindElement(typeCodeDropdownLocator);
            typeCodedropdown.Click();

            codeTextbox = driver.FindElement(codeTextboxLocator);
            codeTextbox.SendKeys(code);

            descriptionTextbox = driver.FindElement(descriptionTextboxLocator);
            descriptionTextbox.SendKeys(description);

            priceTextbox = driver.FindElement(priceTextboxLocator);
            priceTextbox.SendKeys(price);

            saveButton = driver.FindElement(saveButtonLocator);
            saveButton.Click();
        }


        public void EditTimeMaterialRecord(string description)
        {
            //wait is req
            goToLastpageButton = driver.FindElement(goToLastpageButtonLocator);
            goToLastpageButton.Click();

            editNewlyCreatedRecord = driver.FindElement(editNewlyCreatedRecordLocator);
            editNewlyCreatedRecord.Click();

            descriptionTextbox = driver.FindElement(descriptionTextboxLocator);
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(description);
            saveButton.Click();
        }

        public void DeleteTimeMaterialRecord()
        {
            //wait is req
            goToLastpageButton = driver.FindElement(goToLastpageButtonLocator);
            goToLastpageButton.Click();

            deleteNewlyCreatedRecord = driver.FindElement(deleteNewlyCreatedRecordLocator);
            deleteNewlyCreatedRecord.Click();

        }

        public string recordListingPage()
        {
            recordTableHeader = driver.FindElement(recordTableHeaderLocator);
            return recordTableHeader.Text;
        }

        public string successfulTimeMaterialcreation()
        {
            goToLastpageButton = driver.FindElement(goToLastpageButtonLocator);
            goToLastpageButton.Click();
            createdRecord = driver.FindElement(createdRecordLocator);
            return createdRecord.Text;
            


        }
    }
}
