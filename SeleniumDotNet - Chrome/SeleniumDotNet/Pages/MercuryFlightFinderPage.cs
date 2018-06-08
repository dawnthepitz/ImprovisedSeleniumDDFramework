using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumFramework.Commons;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Pages
{
    class MercuryFlightFinderPage:WebPage
    {
        public MercuryFlightFinderPage(ChromeDriver driver):base(driver){

        }
        public void clickOneWay()
        {
            this.Click("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]","xpath");
        }
        public void selectFrom(string input)
        {
            this.SelectByText("fromPort", "name", input);
        }
        public void selectNoOfPassengers(string input)
        {
            this.SelectByText("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select", "xpath", input);
        }
    }
}
