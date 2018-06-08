/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jselenium.pages;

import jselenium.commons.WebPage;
import org.openqa.selenium.WebDriver;

/**
 *
 * @author Number Cruncher Mk.2
 */
public class MercuryFlightFinderPage extends WebPage {

    public MercuryFlightFinderPage(WebDriver driver) {
        super(driver);
    }

    public void clickOneWay() {
        this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]", "xpath");
    }

    public void selectFrom(String input) {
        this.SelectByText("fromPort", "name", input);
    }

    public void selectNoOfPassengers(String input) {
        this.SelectByText("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select", "xpath", input);
    }

}
