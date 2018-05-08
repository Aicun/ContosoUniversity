using System;
using ContosoUniversity.Utils;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class ContextInjectionSteps
    {
        private readonly PersonInfo personData;
        public ContextInjectionSteps(PersonInfo personData) // use it as ctor parameter
        {
            this.personData = personData;
        }

        [Given(@"The person firstname '(.*)' lastname '(.*)'")]
        public void GivenThePersonFirstnameLastname(string firstname, string lastname)
        {
            personData.FirstName = firstname;
            personData.LastName = lastname;
        }
    }
}
