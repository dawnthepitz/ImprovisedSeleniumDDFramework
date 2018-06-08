/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jselenium.scripts;

import jselenium.commons.TestCase;
import jselenium.pages.MercuryFlightFinderPage;
import jselenium.pages.MercuryHomePage;
import jselenium.pages.MercurySignOnPage;
import org.openqa.selenium.WebDriver;

/**
 *
 * @author Number Cruncher Mk.2
 */
public class MercuryTest extends TestCase {

    public MercuryTest(WebDriver driver) {
        super(driver);
    }

    public void test() {
        MercuryHomePage homePage = new MercuryHomePage(driver);
        homePage.load();
        takeScreenshotOfStep(1);
        homePage.clickSignOn();
        takeScreenshotOfStep(2);
        MercurySignOnPage signOnPage = new MercurySignOnPage(driver);
        signOnPage.typeUsername("mercury");
        takeScreenshotOfStep(3);
        signOnPage.typePassword("mercury");
        takeScreenshotOfStep(4);
        signOnPage.clickSubmit();
        takeScreenshotOfStep(5);
        MercuryFlightFinderPage flightFinderPage = new MercuryFlightFinderPage(driver);
        flightFinderPage.clickOneWay();
        takeScreenshotOfStep(6);
        flightFinderPage.selectNoOfPassengers("3");
        takeScreenshotOfStep(7);
        flightFinderPage.selectFrom("London");
    }

}
