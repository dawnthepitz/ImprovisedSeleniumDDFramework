using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumFramework.Commons;
using SeleniumFramework.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramework.Scripts
{
    class MercuryTest:TestCase
    {
        public MercuryTest(ChromeDriver driver):base(driver){
        }
        public void test(){
            var homePage = new MercuryHomePage(driver);
            homePage.load();
            TakeScreenshotOfStep(1);
            homePage.clickSignOn();
            TakeScreenshotOfStep(2);
            var signOnPage = new MercurySignOnPage(driver);
            signOnPage.typeUsername("mercury");
            TakeScreenshotOfStep(3);
            signOnPage.typePassword("mercury");
            TakeScreenshotOfStep(4);
            signOnPage.clickSubmit();
            TakeScreenshotOfStep(5);
            var flightFinderPage = new MercuryFlightFinderPage(driver);
            flightFinderPage.clickOneWay();
            TakeScreenshotOfStep(6);
            flightFinderPage.selectNoOfPassengers("3");
            TakeScreenshotOfStep(7);
            flightFinderPage.selectFrom("London");
        }

    }
}