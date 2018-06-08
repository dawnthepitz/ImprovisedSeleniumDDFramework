using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumFramework.Commons;
using OpenQA.Selenium.PhantomJS;

namespace SeleniumFramework.Pages
{
    class MercurySignOnPage:WebPage
    {
        public MercurySignOnPage(PhantomJSDriver driver):base(driver){

        }
        
        public void typeUsername(string input)
        {
            this.Type("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[1]/td[2]/input", "xpath", input);
        }
        public void typePassword(string input)
        {
            this.Type("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/input", "xpath", input);
        }
        public void clickSubmit()
        {
            this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/input", "xpath");
        }
    }
}
