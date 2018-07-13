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
        private List<TestStep> testSteps;
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

        public void MakeHTMLReport(string fileName)
        {
            string htmlRender = "<h1><b>" + testCaseName + "</b></h1>";
            htmlRender += "Date Tested:" + DateTime.Now;
            htmlRender += "<table border=1>";
            htmlRender += "<b><tr><th>Action</th><th>Expected Result</th><th>Passed?</th></tr></B>";
            foreach (TestStep testStep in testSteps)
            {
                htmlRender += "<b><tr><th>" + testStep.StepAction + "</th><th>" + testStep.ExpectedResult + "</th><th>" + testStep.Passed + "</th></tr></b>";
            }
            htmlRender += "</table>";
            File.Delete(fileName);
            File.AppendAllText(fileName, htmlRender);
        }
        public void MakeHTMLReport()
        {
            string htmlRender = "<h1><b>" + testCaseName + "</b></h1>";
            htmlRender += "Date Tested:" + DateTime.Now;
            htmlRender += "<table border=1>";
            htmlRender += "<b><tr><th>Action</th><th>Expected Result</th><th>Passed?</th></tr></b>";
            foreach (TestStep testStep in testSteps)
            {
                htmlRender += "<b><tr><th>" + testStep.StepAction + "</th><th>" + testStep.ExpectedResult + "</th><th>" + testStep.Passed + "</th></tr></b>";
            }
            htmlRender += "</table>";
            File.Delete(testCaseName + ".html");
            File.AppendAllText(testCaseName + ".html", htmlRender);
        }
    }
}
