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
            TestCase.Log("Enabling human intervention");
            MessageBox.Show("I will be pausing my Execution for Semi-automation purposes");
        }
        protected void DetermineIfExists(string path, string pathType)
        {
            TestCase.Log("Looking for " + pathType+"="+path);
            if (pathType == "id")
            {
                IWebElement element = driver.FindElement(By.Id(path));
                TestCase.Log(pathType + "=" + path+" is found");
            }
            else if (pathType == "name")
            {
                IWebElement element = driver.FindElement(By.Name(path));
                TestCase.Log(pathType + "=" + path + " is found");
            }
            else if (pathType == "class")
            {
                IWebElement element = driver.FindElement(By.ClassName(path));
                TestCase.Log(pathType + "=" + path + " is found");
            }
            else if (pathType == "xpath")
            {
                IWebElement element = driver.FindElement(By.XPath(path));
                TestCase.Log(pathType + "=" + path + " is found");
            }
            else throw new Exception(pathType+"="+path+" does not exist");
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
                    throw new Exception("id=" + path + " has value!=" + value);
                }
            }
            else if (pathType == "name")
            {
                TestCase.Log("Asserting if " + value + " is same as value of name=" + path);
                element = driver.FindElement(By.Name(path));
                if (element.Text != value)
                {
                    throw new Exception("name=" + path + " has value!=" + value);
                }
            }
            else if (pathType == "class")
            {
                TestCase.Log("Asserting if " + value + " is same as value of class=" + path);
                element = driver.FindElement(By.ClassName(path));
                if (element.Text != value)
                {
                    throw new Exception("class=" + path + " has value!=" + value);
                }
            }
            else if (pathType == "xpath")
            {
                TestCase.Log("Asserting if " + value + " is same as value of xpath=" + path);
                element = driver.FindElement(By.XPath(path));
                if (element.Text != value)
                {
                    throw new Exception("xpath=" + path + " has value!=" + value);
                }
            }
            else
            {
                throw new Exception("Nothing to assort with");
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
                    throw new Exception("id=" + path + " has same value=" + value);
                }
            }
            else if (pathType == "name")
            {
                TestCase.Log("Asserting if " + value + " has different value against name=" + path);
                element = driver.FindElement(By.Name(path));
                if (element.Text == value)
                {
                    throw new Exception("name=" + path + " has same value=" + value);
                }
            }
            else if (pathType == "class")
            {
                TestCase.Log("Asserting if " + value + " has different value against class=" + path);
                element = driver.FindElement(By.ClassName(path));
                if (element.Text == value)
                {
                    throw new Exception("class=" + path + " has same value=" + value);
                }
            }
            else if (pathType == "xpath")
            {
                TestCase.Log("Asserting if " + value + " has different value against xpath" + path);
                element = driver.FindElement(By.XPath(path));
                if (element.Text == value)
                {
                    throw new Exception("xpath="+path+" has same value="+value);
                }
            }
            else
            {
                throw new Exception("Nothing to assort against");
            }
        }
    }
}