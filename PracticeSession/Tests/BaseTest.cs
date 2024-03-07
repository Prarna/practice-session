using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PracticeSession.Tests
{
    public class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]

        public void launchBrowser()
        { 
            new DriverManager().SetUpDriver(config: new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
           
        }
    }
}
