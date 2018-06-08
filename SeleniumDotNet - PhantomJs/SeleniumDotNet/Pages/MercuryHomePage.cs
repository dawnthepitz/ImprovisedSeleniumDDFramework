using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumFramework.Commons;
using OpenQA.Selenium.PhantomJS;

namespace SeleniumFramework.Pages
{
    class MercuryHomePage:WebPage
    {
        public MercuryHomePage(PhantomJSDriver driver):base(driver){

        }
        public void load()
        {
            this.LoadPage("http://newtours.demoaut.com");
        }
        public void clickSignOn()
        {
            this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a", "xpath");
        }
    }
}