using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFramework.Commons
{
    class WebPage
    {
        protected ChromeDriver driver;

        public WebPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        protected void LoadPage(string url)
        {
            driver.Url = url;
            TestCase.Log("Entering "+url);
        }

        protected void Click(string path, string pathType)
        {

            if (pathType == "id")
            {
                IWebElement element = driver.FindElement(By.Id(path));
                element.Click();
                TestCase.Log("Clicked element with id=" + path);
            }
            else if (pathType == "name")
            {
                IWebElement element = driver.FindElement(By.Name(path));
                element.Click();
                TestCase.Log("Clicked element with name=" + path);
            }
            else if (pathType == "class")
            {
                IWebElement element = driver.FindElement(By.ClassName(path));
                element.Click();
                TestCase.Log("Clicked element with class=" + path);
            }
            else if (pathType == "xpath")
            {
                IWebElement element = driver.FindElement(By.XPath(path));
                element.Click();
                TestCase.Log("Clicked element with xpath=" + path);
            }
        }

        protected void Type(string path, string pathType, string value)
        {
            if (pathType == "id")
            {
                IWebElement element = driver.FindElementById(path);
                element.Clear();
                element.SendKeys(value);
                TestCase.Log("Entered "+value+" at element with id=" + path);
            }
            if (pathType == "name")
            {
                IWebElement element = driver.FindElementByName(path);
                element.Clear();
                element.SendKeys(value);
                TestCase.Log("Entered " + value + " at element with name=" + path);
            }
            if (pathType == "class")
            {
                IWebElement element = driver.FindElementByClassName(path);
                element.Clear();
                element.SendKeys(value);
                TestCase.Log("Entered " + value + " at element with class=" + path);
            }
            if (pathType == "xpath")
            {
                IWebElement element = driver.FindElementByXPath(path);
                element.Clear();
                element.SendKeys(value);
                TestCase.Log("Entered " + value + " at element with xpath=" + path);
            }
        }

        protected void SelectByText(string path, string pathType, string value)
        {
            if (pathType == "id")
            {
                SelectElement select = new SelectElement(driver.FindElementById(path));
                select.SelectByText(value);
                TestCase.Log("Selected " + value + " at element with id=" + path);
            }
            if (pathType == "name")
            {
                SelectElement select = new SelectElement(driver.FindElementByName(path));
                select.SelectByText(value);
                TestCase.Log("Selected " + value + " at element with name=" + path);
            }
            if (pathType == "class")
            {
                SelectElement select = new SelectElement(driver.FindElementByClassName(path));
                select.SelectByText(value);
                TestCase.Log("Selected " + value + " at element with class=" + path);
            }
            if (pathType == "xpath")
            {
                SelectElement select = new SelectElement(driver.FindElementByXPath(path));
                select.SelectByText(value);
                TestCase.Log("Selected " + value + " at element with xpath=" + path);
            }
        }
    }
}
