using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium;

namespace SeleniumFramework.Commons
{
    class TestCase
    {
        protected PhantomJSDriver driver;
        protected TestScript testScript;
        public TestCase(PhantomJSDriver driver)
        {
            this.driver = driver;
            testScript = new TestScript(this.GetType().Name);
        }
        public static void Log(string log)
        {
            Console.WriteLine(log);
        }
        public void TakeScreenshotOfStep(int stepNo)
        {
            driver.GetScreenshot().SaveAsFile(this.GetType().Name + "-Step#" + stepNo + ".png", ScreenshotImageFormat.Png);
        }
    }
}