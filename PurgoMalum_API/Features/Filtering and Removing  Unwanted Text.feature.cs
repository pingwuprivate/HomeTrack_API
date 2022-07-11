﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.10.0.0
//      SpecFlow Generator Version:3.10.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PurgoMalum_API.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.10.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Filtering and Removing Unwanted Text")]
    public partial class FilteringAndRemovingUnwantedTextFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Filtering and Removing  Unwanted Text.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Filtering and Removing Unwanted Text", @"	This feature file is collection of all necessary test scenarios of PurgoMalum web service used to filter out 
unwanted contents through  it's Web API
    It includes
	 1 filter and remove all text in profanity lists and displayed as * by default
	   case insensitive
	   part of word or words
	   at front , middle, and end
	 2 Add new word as profanity text and can be filtered out and displayed as * by default
	 3 Filter profannity text replace by the specified word chracters or symbols
	 4 Error Handling scenarios
	   Empty string
	   replacing word is more than 20 characters
	5  It only test JSON Method ", ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 15
#line hidden
#line 16
   await testRunner.GivenAsync("A user setup the web server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Default")]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word\"", "\"without profanity word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with unwanted word boner\"", "\"with unwanted word *****\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with chink unwanted word\"", "\"with ***** unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"shit with unwanted word\"", "\"**** with unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"SHIT with unwanted word\"", "\"**** with unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is Shit and that is ass\"", "\"this is **** and that is ***\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"aa bb cc dd eee fff ggg hhh iii jjj vv\"", "\"aa bb cc dd eee fff ggg hhh iii jjj vv\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_Default(string inputText, string expectedText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedText", expectedText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Default", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
this.FeatureBackgroundAsync();
#line hidden
#line 20
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 await testRunner.ThenAsync(string.Format("The result should be {0}", expectedText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Advanced")]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word&add=word\"", "\"without profanity ****\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word&add=word&fill_text=aaaa\"", "\"without profanity aaaa\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with unwanted word boner&fill_text=[replaced]\"", "\"with unwanted word [replaced]\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with chink unwanted word&fill_text=_____\"", "\"with _____ unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"COCK with unwanted word&fill_text=hhhh\"", "\"hhhh with unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is Shit and that is ass&fill_text=____\"", "\"this is ____ and that is ____\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,vv\"", "\"** ** ** ** *** *** *** *** *** jjj **\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_Advanced(string inputText, string expectedText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedText", expectedText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Advanced", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
this.FeatureBackgroundAsync();
#line hidden
#line 35
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 await testRunner.ThenAsync(string.Format("The result should be {0}", expectedText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Error Handling")]
        [NUnit.Framework.TestCaseAttribute("\"      \"", "\"No Input\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is some test input&fill_text=this is long replacement text\"", "\"User Replacement Text Exceeds Limit of 20 Characters.\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,jjj,v" +
            "v\"", "\"User Black List Exceeds Limit of 10 Words.\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_ErrorHandling(string inputText, string expectedText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedText", expectedText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Error Handling", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
this.FeatureBackgroundAsync();
#line hidden
#line 50
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 await testRunner.ThenAsync(string.Format("The error messages should be {0}", expectedText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Status check")]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word\"", "\"False\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with unwanted word boner\"", "\"True\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with chink unwanted word\"", "\"True\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"cock with unwanted word\"", "\"True\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"COCK with unwanted word\"", "\"True\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_StatusCheck(string inputText, string expectedStatus, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedStatus", expectedStatus);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Status check", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
this.FeatureBackgroundAsync();
#line hidden
#line 61
    await testRunner.GivenAsync(string.Format("The User entered text check if containing profanity words {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 62
 await testRunner.WhenAsync("The user Request Web Service for status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 await testRunner.ThenAsync(string.Format("The expected status is {0}", expectedStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
