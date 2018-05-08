using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow.TestCases
{
    [Binding]
    public class FeatureContextSteps
    {
        [When(@"I execute any scenario in the feature")]
        public void WhenIExecuteAnyScenarioInTheFeature()
        {
        }
        
        [Then(@"the FeatureInfo contains the following information")]
        public void ThenTheFeatureInfoContainsTheFollowingInformation(Table table)
        {// Create our small DTO for the info from the step
            var fromStep = table.CreateInstance<FeatureInformation>();
            fromStep.Tags = table.Rows[0]["Value"].Split(',');

            var fi = FeatureContext.Current.FeatureInfo;

            // Assertions
            Assert.AreEqual(fi.Title,fromStep.Title);
            //fi.GenerationTargetLanguage.Should().Equal(fromStep.TargetLanguage);
            Assert.IsTrue(fi.Description.StartsWith(fromStep.Description));
            Assert.AreEqual(fi.Language.IetfLanguageTag,fromStep.Language);
            for (var i = 0; i < fi.Tags.Length - 1; i++)
            {
                Assert.AreEqual(fi.Tags[i],fromStep.Tags[i]);
            }
            ScenarioContext.Current.Pending();
        }

        private class FeatureInformation
        {
            public string Title { get; set; }
            //public GenerationTargetLanguage TargetLanguage { get; set; }
            public string Description { get; set; }
            public string Language { get; set; }
            public string[] Tags { get; set; }
        }
    }
}
