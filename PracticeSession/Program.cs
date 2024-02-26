

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

