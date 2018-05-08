using System;
using ContosoUniversity.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlow.TestCases
{
    [Binding]
    public class UpdateCourseCreditsSteps
    {
        private int result { get; set; }
        Calculation cc = new Calculation();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNumber)
        {
           cc.FirstNumber = firstNumber;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondNumber)
        {
            cc.SecondNumber = secondNumber;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = cc.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
