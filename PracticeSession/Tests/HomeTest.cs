using NUnit.Framework;
using PracticeSession.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Tests
{
    public class HomeTest : BaseTest 
    {
        private HomePage homePage = new HomePage(driver);
        private TimeMaterialPage timematerialPage = new TimeMaterialPage(driver);

        [Test]
        public void userNavigateToTimeMaterialPage()
        {
            homePage.homePageActions();
            Assert.That(timematerialPage.IsCreateNewButtonVisible, Is.EqualTo("Create New"));
        }
    }
}
