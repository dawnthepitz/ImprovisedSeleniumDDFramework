/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jselenium.commons;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.Select;

/**
 *
 * @author Number Cruncher Mk.2
 */
public class WebPage {

    protected WebDriver driver;

    public WebPage(WebDriver driver) {
        this.driver = driver;
    }

    protected void LoadPage(String url) {
        driver.navigate().to(url);
        TestCase.Log("Entering " + url);
    }

    protected void Click(String path, String pathType) {

        if (pathType == "id") {
            WebElement element = driver.findElement(By.id(path));
            element.click();
            TestCase.Log("Clicked element with id=" + path);
        } else if (pathType == "name") {
            WebElement element = driver.findElement(By.name(path));
            element.click();
            TestCase.Log("Clicked element with name=" + path);
        } else if (pathType == "class") {
            WebElement element = driver.findElement(By.className(path));
            element.click();
            TestCase.Log("Clicked element with class=" + path);
        } else if (pathType == "xpath") {
            WebElement element = driver.findElement(By.xpath(path));
            element.click();
            TestCase.Log("Clicked element with xpath=" + path);
        }
    }

    protected void Type(String path, String pathType, String value) {
        if (pathType == "id") {
            WebElement element = driver.findElement(By.id(path));
            element.sendKeys(value);
            TestCase.Log("Entered " + value + " at element with id=" + path);
        }
        if (pathType == "name") {
            WebElement element = driver.findElement(By.name(path));
            element.sendKeys(value);
            TestCase.Log("Entered " + value + " at element with name=" + path);
        }
        if (pathType == "class") {
            WebElement element = driver.findElement(By.className(path));
            element.sendKeys(value);
            TestCase.Log("Entered " + value + " at element with class=" + path);
        }
        if (pathType == "xpath") {
            WebElement element = driver.findElement(By.xpath(path));
            element.sendKeys(value);
            TestCase.Log("Entered " + value + " at element with xpath=" + path);
        }
    }

    protected void SelectByText(String path, String pathType, String value) {
        if (pathType == "id") {
            Select select = new Select(driver.findElement(By.id(path)));
            select.selectByVisibleText(value);
            TestCase.Log("Selected " + value + " at element with id=" + path);
        }
        if (pathType == "name") {
            Select select = new Select(driver.findElement(By.name(path)));
            select.selectByVisibleText(value);
            TestCase.Log("Selected " + value + " at element with id=" + path);
        }
        if (pathType == "class") {
            Select select = new Select(driver.findElement(By.className(path)));
            select.selectByVisibleText(value);
            TestCase.Log("Selected " + value + " at element with id=" + path);
        }
        if (pathType == "xpath") {
            Select select = new Select(driver.findElement(By.xpath(path)));
            select.selectByVisibleText(value);
            TestCase.Log("Selected " + value + " at element with id=" + path);
        }
    }
}
