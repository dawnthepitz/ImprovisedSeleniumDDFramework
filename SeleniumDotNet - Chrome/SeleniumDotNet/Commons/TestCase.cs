using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramework.Commons
{
    class TestCase
    {
        protected ChromeDriver driver;
        public TestCase(ChromeDriver driver)
        {
            this.driver = driver;
        }
        public static void Log(string log)
        {
            Console.WriteLine(log);
        }
        public void TakeScreenshotOfStep(int stepNo)
        {
            driver.GetScreenshot().SaveAsFile(this.GetType().Name+"-Step#"+stepNo+".png", ScreenshotImageFormat.Png);
        }
    }
}