/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jselenium.commons;
import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;
import org.apache.commons.io.FileUtils;
/**
 *
 * @author Number Cruncher Mk.2
 */
public class TestCase {

    protected WebDriver driver;

    public TestCase(WebDriver driver) {
        this.driver = driver;
    }

    public static void Log(String log) {
        System.out.println(log);
    }
    
    public void takeScreenshotOfStep(int stepNo){
        try {
            File scrFile = ((TakesScreenshot)driver).getScreenshotAs(OutputType.FILE);
            // Now you can do whatever you need to do with it, for example copy somewhere
            FileUtils.copyFile(scrFile, new File(this.getClass().getSimpleName()+"-Step#"+stepNo+".png"));
        } catch (IOException ex) {
            Logger.getLogger(TestCase.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
