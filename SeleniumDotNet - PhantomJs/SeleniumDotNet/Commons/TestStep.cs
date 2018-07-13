using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumFramework.Commons
{
    class TestStep
    {
        private string stepAction;
        private string expectedResult;
        private bool passed;

        public TestStep(string stepAction, string expectedResult)
        {
            this.stepAction = stepAction;
            this.expectedResult = expectedResult;
            passed = false;
        }

        public string StepAction
        {
            get
            {
                return stepAction;
            }
            set
            {
                stepAction = value;
            }
        }
        public string ExpectedResult
        {
            get
            {
                return expectedResult;
            }
            set
            {
                expectedResult = value;
            }
        }

        public bool Passed
        {
            get
            {
                return passed;
            }
        }

        public void Check()
        {
            passed = true;
        }
    }
}
