/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jselenium;
import jselenium.scripts.MercuryTest;
import org.openqa.selenium.chrome.ChromeDriver;
/**
 *
 * @author Number Cruncher Mk.2
 */
public class Program {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ChromeDriver driver=new ChromeDriver();
        driver.manage().window().maximize();
        MercuryTest test=new MercuryTest(driver);
        test.test();
        driver.quit();
    }
    
}
