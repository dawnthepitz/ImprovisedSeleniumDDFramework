using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Scripts;

namespace SeleniumFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); 
            MercuryTest test = new MercuryTest(driver);
            test.test();
            driver.Quit();
        }
    }
}
