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
    class MercuryTest : TestCase
    {
        public MercuryTest(ChromeDriver driver)
            : base(driver)
        {
        }
        public void test()
        {
            testScript.TestSteps.Add(new TestStep("Visit newtours.demoaut.com", "newtours.demoaut.com should show on page"));
            testScript.TestSteps.Add(new TestStep("Click the sign on page", "Sign-On page must be shown"));
            testScript.TestSteps.Add(new TestStep("Enter username", "Username must be displayed on textbox"));
            testScript.TestSteps.Add(new TestStep("Enter password", "Password must be entered on textbox"));
            testScript.TestSteps.Add(new TestStep("Click Submit", "Flight finder page must be shown"));
            testScript.TestSteps.Add(new TestStep("Select One way", "One way is selected"));
            testScript.TestSteps.Add(new TestStep("Select number of passengers", "User has selected number of passengers"));
            testScript.TestSteps.Add(new TestStep("Select From", "User has selected From"));
            try
            {
                var homePage = new MercuryHomePage(driver);

                homePage.load();
                TakeScreenshotOfStep(1);
                testScript.CheckTestStepNo(1);

                homePage.clickSignOn();
                TakeScreenshotOfStep(2);
                testScript.CheckTestStepNo(2);

                var signOnPage = new MercurySignOnPage(driver);

                signOnPage.typeUsername("mercury");
                TakeScreenshotOfStep(3);
                testScript.CheckTestStepNo(3);

                signOnPage.typePassword("mercury");
                TakeScreenshotOfStep(4);
                testScript.CheckTestStepNo(4);

                signOnPage.clickSubmit();
                TakeScreenshotOfStep(5);
                testScript.CheckTestStepNo(5);

                var flightFinderPage = new MercuryFlightFinderPage(driver);

                flightFinderPage.clickOneWay();
                TakeScreenshotOfStep(6);
                testScript.CheckTestStepNo(6);

                flightFinderPage.selectNoOfPassengers("3");
                TakeScreenshotOfStep(7);
                testScript.CheckTestStepNo(7);

                flightFinderPage.selectFrom("London");
                TakeScreenshotOfStep(8);
                testScript.CheckTestStepNo(8);
            }
            finally
            {
                testScript.MakeHTMLReport();
            }
        }

    }
}