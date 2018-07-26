using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace SeleniumFramework.Commons
{
    class TestScript
    {
        private string testCaseName;
        private string testCaseDescription;
        private List<TestStep> testSteps;
        private List<string> assumptions;
        private DateTime startDate;
        public string TestCaseName
        {
            get
            {
                return testCaseName;
            }
            set
            {
                testCaseName = value;
            }
        }
        public string Description
        {
            set
            {
                testCaseDescription = value;
            }
        }
        public List<string> Assumptions
        {
            get
            {
                return assumptions;
            }
        }
        public List<TestStep> TestSteps
        {
            get
            {
                return testSteps;
            }
        }
        public TestScript()
        {
            testSteps = new List<TestStep>();
            startDate = DateTime.Now;
            assumptions = new List<string>();
        }
        public TestScript(string testCaseName)
            : this()
        {
            this.testCaseName = testCaseName;
        }

        public void CheckTestStepNo(int no)
        {
            TestSteps[no - 1].Check();
        }
        public string OverAllStatus()
        {
            foreach (TestStep testStep in testSteps)
            {
                if (!testStep.Passed)
                    return "<font color='red'>Failed</font>";
            }
            return "<font color='green'>Passed</font>";
        }
        public void MakeHTMLReport()
        {
            string htmlRender = "<h1><b>" + testCaseName + "</b></h1>";
            htmlRender += "<h4><i>" + testCaseDescription + "</i></h4>";
            htmlRender += "Start of Test:" + startDate + "<br>";
            htmlRender += "End of Test:" + DateTime.Now + "<br>";
            htmlRender += "Status:" + OverAllStatus() + "<br><br>";
            htmlRender += "Assumptions:<ul>";
            foreach (string assumption in assumptions)
            {
                htmlRender += "<li>" + assumption + "</li>";
            }
            htmlRender += "</ul>";
            htmlRender += "<table border=1>";
            htmlRender += "<b><tr><th>Step No</th><th>Action</th><th>Expected Result</th><th>Remarks</th><th>Screenshot</th></tr></b>";
            for (int i = 0; i < TestSteps.Count; i++)
            {
                htmlRender += "<tr><td>" + (i + 1) + "</td><td>" + testSteps[i].StepAction + "</td><td>" + testSteps[i].ExpectedResult + "</td><td bgcolor='" + (testSteps[i].Passed ? "green" : "red") + "'><font color='white'>" + (testSteps[i].Passed ? "Passed" : "Failed") + "</font></td><td><a href='" + testCaseName + "-Step" + (i + 1) + ".png'><img src='" + testCaseName + "-Step" + (i + 1) + ".png' width=640 height=480></a></tr>";
            }
            htmlRender += "</table>";
            File.Delete(testCaseName + ".html");
            File.AppendAllText(testCaseName + ".html", htmlRender);
        }
    }
}
