﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.TestCases
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Test transform input Table to Ojbect", SourceFile="TestCases\\Transform.feature", SourceLine=0)]
    public partial class TestTransformInputTableToOjbectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Transform.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Test transform input Table to Ojbect", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
  testRunner.Given("I have entered value \'good morning\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
  testRunner.And("I have entered another value \'Lu\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void TransformTable(string firstName, string lastName, string birthDate, string gender, string age, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Transform"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Transform Table", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "firstName",
                        "lastName",
                        "birthDate",
                        "gender",
                        "age"});
            table1.AddRow(new string[] {
                        string.Format("{0}", firstName),
                        string.Format("{0}", lastName),
                        string.Format("{0}", birthDate),
                        string.Format("{0}", gender),
                        string.Format("{0}", age)});
#line 9
    testRunner.Given("I created a person with properties as follows:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "BirthDate"});
            table2.AddRow(new string[] {
                        "1999-01-01"});
#line 12
    testRunner.And("I have change the person with the following properties:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "BirthDate",
                        "Gender",
                        "Age",
                        "Greeting"});
            table3.AddRow(new string[] {
                        "Aicun",
                        "Lu",
                        "1999-01-01",
                        "Male",
                        "13",
                        "good morning Lu"});
#line 16
    testRunner.Then("the person infomation should be:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Transform Table, Aicun", new string[] {
                "Transform"}, SourceLine=21)]
        public virtual void TransformTable_Aicun()
        {
            this.TransformTable("Aicun", "Lu", "2001-01-01", "Male", "13", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TestHooks", new string[] {
                "TestHooks"}, SourceLine=24)]
        public virtual void TestHooks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestHooks", new string[] {
                        "TestHooks"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 26
 testRunner.Given("I have a before test method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("I hava an after test method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "BirthDate"});
            table4.AddRow(new string[] {
                        "1999-01-01"});
#line 28
 testRunner.And("I have change the person with the following properties:", ((string)(null)), table4, "And ");
#line 31
 testRunner.Then("they should be executed only once", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Test Complex Comversion", new string[] {
                "TestComplexConversion"}, SourceLine=34)]
        public virtual void TestComplexComversion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Complex Comversion", new string[] {
                        "TestComplexConversion"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Color"});
            table5.AddRow(new string[] {
                        "XL",
                        "Blue"});
            table5.AddRow(new string[] {
                        "L",
                        "Red"});
#line 36
 testRunner.Given("I have entered following properties:", ((string)(null)), table5, "Given ");
#line 40
 testRunner.Then("the converted result should be a complex object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
