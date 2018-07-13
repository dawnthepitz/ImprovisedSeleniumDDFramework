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
        protected void DetermineIfExists(string path, string pathType)
        {
            TestCase.Log("Looking for Element:" + path+" with PathType:"+pathType);
            if (pathType == "id")
            {
                IWebElement element = driver.FindElement(By.Id(path));
            }
            else if (pathType == "name")
            {
                IWebElement element = driver.FindElement(By.Name(path));
            }
            else if (pathType == "class")
            {
                IWebElement element = driver.FindElement(By.ClassName(path));
            }
            else if (pathType == "xpath")
            {
                IWebElement element = driver.FindElement(By.XPath(path));
            }
            else throw new Exception();
        }
        protected void AssertEquals(string path, string pathType, string value)
        {
            IWebElement element;
            if (pathType == "id")
            {
                TestCase.Log("Asserting if " + value + " is same as value of id=" + path);
                element = driver.FindElement(By.Id(path));
                if (element.Text != value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "name")
            {
                TestCase.Log("Asserting if " + value + " is same as value of name=" + path);
                element = driver.FindElement(By.Name(path));
                if (element.Text != value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "class")
            {
                TestCase.Log("Asserting if " + value + " is same as value of class=" + path);
                element = driver.FindElement(By.ClassName(path));
                if (element.Text != value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "xpath")
            {
                TestCase.Log("Asserting if " + value + " is same as value of xpath=" + path);
                element = driver.FindElement(By.XPath(path));
                if (element.Text != value)
                {
                    throw new Exception();
                }
            }
            else
            {
                TestCase.Log("Nothing to assort with");
                throw new Exception();
            }
        }
        protected void AssertNotEquals(string path, string pathType, string value)
        {
            IWebElement element;
            if (pathType == "id")
            {
                TestCase.Log("Asserting if " + value + " has different value against id=" + path);
                element = driver.FindElement(By.Id(path));
                if (element.Text == value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "name")
            {
                TestCase.Log("Asserting if " + value + " has different value against name=" + path);
                element = driver.FindElement(By.Name(path));
                if (element.Text == value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "class")
            {
                TestCase.Log("Asserting if " + value + " has different value against class=" + path);
                element = driver.FindElement(By.ClassName(path));
                if (element.Text == value)
                {
                    throw new Exception();
                }
            }
            else if (pathType == "xpath")
            {
                TestCase.Log("Asserting if " + value + " has different value against xpath" + path);
                element = driver.FindElement(By.XPath(path));
                if (element.Text == value)
                {
                    throw new Exception();
                }
            }
            else
            {
                TestCase.Log("Nothing to assort against");
                throw new Exception();
            }
        }
    }
}