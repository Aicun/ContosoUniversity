using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow
{
    [Binding]
    public class ScenarioContextSteps
    {
        [When(@"I execute any scenario")]
        public void WhenIExecuteAnyScenario()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the ScenarioInfo contains the following information")]
        public void ThenTheScenarioInfoContainsTheFollowingInformation(Table table)
        {
            // Create our small DTO for the info from the step
            var fromStep = table.CreateInstance<ScenarioInformation>();
            fromStep.Tags = table.Rows[0]["Value"].Split(',');

            // Short-hand to the scenarioInfo
            var si = ScenarioContext.Current.ScenarioInfo;

            // Assertions
            Assert.AreEqual(si.Title,fromStep.Title);
            for (var i = 0; i < si.Tags.Length - 1; i++)
            {
                Assert.AreEqual(si.Tags[i],fromStep.Tags[i]);
            }
        }

        [When("an error occurs in a step")]
        public void AnErrorOccurs()
        {
            Assert.AreEqual("not correct","correct");
        }

        [AfterScenario("showingErrorHandling")]
        public void AfterScenarioHook()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                var error = ScenarioContext.Current.TestError;
                Console.WriteLine("An error ocurred:" + error.Message);
                Console.WriteLine("It was of type:" + error.GetType().Name);
            }
        }

        [Given("I have a (.*) step")]
        [Given("I have another (.*) step")]
        [When("I have a (.*) step")]
        [Then("I have a (.*) step")]
        public void ReportStepTypeName(string expectedStepType)
        {
            var stepType = ScenarioContext.Current.CurrentScenarioBlock.ToString();
            Assert.AreEqual(stepType,expectedStepType);
        }

        private class ScenarioInformation
        {
            public string Title { get; set; }
            public string[] Tags { get; set; }
        }
    }
}
