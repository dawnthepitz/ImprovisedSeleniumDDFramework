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
public class MercuryHomePage extends WebPage{

    public MercuryHomePage(WebDriver driver) {
        super(driver);
    }
        public void load() {
        this.LoadPage("http://newtours.demoaut.com");
    }

    public void clickSignOn() {
        this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a", "xpath");
    }
}
