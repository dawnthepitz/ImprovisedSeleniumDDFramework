using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramework.Commons
{
    class TestCase
    {
        protected ChromeDriver driver;
        protected TestScript testScript;
        public TestCase(ChromeDriver driver)
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
            driver.GetScreenshot().SaveAsFile(this.GetType().Name+ "-Step#" + stepNo + ".png", ScreenshotImageFormat.Png);
        }
        public static void LetHumanIntervene()
        {
            MessageBox.Show("I will be pausing my Execution for Semi-automation purposes");
        }
    }
}