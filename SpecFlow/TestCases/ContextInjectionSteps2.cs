using System;
using ContosoUniversity.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class ContextInjectionSteps2
    {
        private readonly PersonInfo personData;
        public ContextInjectionSteps2(PersonInfo personData) // ctor parameter here too
        {
            this.personData = personData;
        }

        [Then(@"The person data is properly displayed")]
        public void ThenThePersonDataIsProperlyDisplayed()
        {
            string displayedData = "firstname lastname";
            Assert.AreEqual(personData.FirstName+" "+personData.LastName,displayedData,"Person name was not displayed properly");
        }
    }
}
