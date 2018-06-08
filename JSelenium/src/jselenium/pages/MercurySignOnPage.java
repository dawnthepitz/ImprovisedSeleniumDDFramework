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
public class MercurySignOnPage extends WebPage{

    public MercurySignOnPage(WebDriver driver) {
        super(driver);
    }

    public void typeUsername(String input) {
        this.Type("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[1]/td[2]/input", "xpath", input);
    }

    public void typePassword(String input) {
        this.Type("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/input", "xpath", input);
    }

    public void clickSubmit() {
        this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/input", "xpath");
    }

}
