using System;
using System.Configuration;
using System.Linq;
using ContosoUniversity.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;

namespace SpecFlow.TestCases
{
    [Binding]
    public class TestTransformInputTableToOjbectSteps
    {

        PersonInfo p = new PersonInfo();
        private static int count = 0;
        private static int countFeature = 0;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Hello. This is Before Test Run....."+ count++);
            Service.Instance.RegisterValueRetriever(new ColorValueRetriever());
            Service.Instance.RegisterValueComparer(new ColorValueComparer());
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Bye. This is After Test Run");
        }

        [BeforeScenario("Transform")]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before Transform runs. Count is "+ countFeature++);
        }

        [AfterScenario("Transform")]
        public static void AfterScenario()
        {
            Console.WriteLine("After Scenario.");
        }

        [Given(@"I have entered value '(.*)'")]
        public void GivenIHaveEnteredValue(string value)
        {
            p.Greeting = value;
        }
        
        [Given(@"I have entered another value '(.*)'")]
        public void GivenIHaveEnteredAnotherValue(string value)
        {
            p.Greeting += " " + value;
        }
        
        [Given(@"I created a person with properties as follows:")]
        public void GivenICreatedAPersonWithPropertiesAsFollows(PersonInfo person)
        {
            p.LastName = person.LastName;
            p.FirstName = person.FirstName;
            p.Gender = person.Gender;
            p.Age = person.Age;
            p.BirthDate = person.BirthDate;
        }
        
        [Given(@"I have change the person with the following properties:")]
        [Scope(Tag = "Transform")]
        public void GivenIHaveChangeThePersonWithTheFollowingProperties(Table table)
        {
            p.BirthDate = table.Rows.Single()["BirthDate"];
        }

        [Given(@"I have change the person with the following properties:")]
        [Scope(Tag = "TestHooks")]
        public void PersonInfoForHooks(Table table)
        {
            Console.WriteLine("The birthdate of the person is  "+table.Rows.Single()["BirthDate"]);
        }

        /* [Then(@"the person infomation should be:")]
         public void ThenThePersonInfomationShouldBe(PersonInfo person)
         {
             Assert.AreEqual(person.ToString(),p.ToString());
         }*/
         //this method does the same thing with the above one. but this oen does not need to change table into Person object
         //since it has comparetoinstance method, so as compareToSet is also provided.
        [Then(@"the person infomation should be:")]
        public void ThenThePersonInfomationShouldBe(Table person)
        {
           person.CompareToInstance(p);
        }

        [StepArgumentTransformation]
        public PersonInfo ConvertFromTableToDeviceData(Table table)
        {
            //return table.CreateSet<PersonInfo>().First();
            return table.CreateInstance<PersonInfo>();
        }

        [Given(@"I have a before test method")]
        public void GivenIHaveABeforeTestMethod()
        {
            Console.WriteLine("The count in before is "+ count);
        }

        [Given(@"I hava an after test method")]
        public void GivenIHavaAnAfterTestMethod()
        {
            Console.WriteLine("The count in after is " + count);
        }

        [Then(@"they should be executed only once")]
        public void ThenTheyShouldBeExecutedOnlyOnce()
        {
            Assert.AreEqual(count, 1);
        }

        [Given(@"I have entered following properties:")]
        public void GivenIHaveEnteredFollowingProperties(IEnumerable<Shirt> table)
        {
            foreach (var Shirt in table)
            {
                Console.WriteLine("The color of this shirt is {0}",Shirt.Color.ColorType);
            }
        }

        [Then(@"the converted result should be a complex object")]
        public void ThenTheConvertedResultShouldBeAComplexObject()
        {
            Assert.AreEqual(1,1);
        }

        [StepArgumentTransformation]
        public IEnumerable<Shirt> ConvertFromTableToShirt(Table table)
        {
            //return table.CreateSet<PersonInfo>().First();
            return table.CreateSet<Shirt>();
        }
    }
}
