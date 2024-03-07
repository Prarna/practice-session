using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Utilities
{
    public class WaitUtils
    {
        private const int Timeout = 15;
        public static void WaitToBeVisible(IWebDriver driver, By by, int seconds = Timeout)
        {
            WebDriverWait wait =  new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }
        public static void WaitToBeClickable(IWebDriver driver, int seconds, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }


    }
}
