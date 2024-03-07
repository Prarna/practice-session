using NUnit.Framework;
using PracticeSession.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession.Tests
{
    public class TimeMaterialTest : BaseTest
    {
        private TimeMaterialPage timeMaterialPage = new TimeMaterialPage(driver);
        public void verifyUserNavigatesBackToRecordListingPage()
        {
            timeMaterialPage.CreateTimeMaterialRecord("TestingCode","create test", "233");
            Assert.That(timeMaterialPage.recordListingPage, Is.EqualTo("Go to the last page"));

        }

        public void verifyCreatedRecordAppearsInTheRecordListingPage()
        {
            //timeMaterialPage.successfulTimeMaterialcreation();
            Assert.That(timeMaterialPage.successfulTimeMaterialcreation, Is.EqualTo("TestingCode"));
            Console.WriteLine("New Material Record has been created successfully.");
            
        }
    }
}
