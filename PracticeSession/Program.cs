

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




//Launch Chrome Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//Launch TurnUp Portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Identify username and password
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMicroseconds(30));
IWebElement passwordTextbox = wait.Until(driver => driver.FindElement(By.Id("Password")));
//IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify Login button
IWebElement loginButton = driver.FindElement(By.XPath("//input[@value = \"Log in\"]"));
loginButton.Click();

//Check if user has logged in successfully
IWebElement userProfileName = driver.FindElement(By.XPath("//*[contains(text(),'Hello hari!')]"));
//IWebElement userProfileName = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
//userProfileName.Click();

if (userProfileName.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");

}
else
{
    Console.WriteLine("User hasn't been logged in ");
}

// Create a new Time record

// Navigate to Time and Material module
IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
administrationDropdown.Click();
IWebElement timeAndMaterialOption = driver.FindElement(By.LinkText("Time & Materials"));
timeAndMaterialOption.Click();

//Click on Create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//a[contains(text(), 'Create New')]"));
createNewButton.Click();

//Select Time from dropdown
IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
typeCodeMainDropdown.Click();
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//span[@class='k-input']"));
typeCodeDropdown.Click();

//Enter Code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Material2024");

//Enter Description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("MaterialDescription");


//Enter the price
IWebElement priceTextbox = driver.FindElement(By.XPath("//input[@class= 'k-formatted-value k-input']"));
priceTextbox.SendKeys("200");

//Click on the Save Button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();


//Check if a new time record has been created successfully
Thread.Sleep(1000);
IWebElement goToLastpageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
goToLastpageButton.Click();

IWebElement newRecordCode = driver.FindElement(By.XPath("//td[normalize-space()='Material2024']"));
if (newRecordCode.Text == "Material2024")
{
    Console.WriteLine("New Material Record has been created successfully.");
}
else
{
    Console.WriteLine("New Material/Time Record has not been created.");
}

// Edit the new created record.
IWebElement editNewlyCreatedRecord = driver.FindElement(By.XPath("//a[@class='k-button k-button-icontext k-grid-Edit'][normalize-space()='Edit'][//td[normalize-space()='Material2024']]"));
editNewlyCreatedRecord.Click();
IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
editDescriptionTextbox.Clear();
editDescriptionTextbox.SendKeys("Updated Description");
IWebElement saveUpadtedData = driver.FindElement(By.Id("SaveButton"));
saveUpadtedData.Click();


//Delete the Newly created record.
Thread.Sleep(1000); 
IWebElement goToLastpageButtonToDelete = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
goToLastpageButtonToDelete.Click();
IWebElement deleteNewlyCreatedRecord = driver.FindElement(By.XPath("//a[@class='k-button k-button-icontext k-grid-Delete'][normalize-space()='Delete'][//td[normalize-space()='Material2024']]"));
deleteNewlyCreatedRecord.Click();
