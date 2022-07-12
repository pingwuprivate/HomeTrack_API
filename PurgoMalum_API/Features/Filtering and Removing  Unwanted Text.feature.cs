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
	 1 Filter and remove all text in profanity lists and displayed as * by default
	   case insensitive
	   part of word or words
	   at front , middle, and end
	 2 Add new word or words as profanity text and can be filtered out and displayed as * by default
	 3 Replace profanity text by the specified word or symbols
	 4 Add and replace the profanity text in the same time 
	 5 Error Handling scenarios
	   Empty string
	   replacing word is more than 20 characters
	   Added bad word is more than 10 word
	6  It only test JSON Method ", ProgrammingLanguage.CSharp, featureTags);
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
#line 17
#line hidden
#line 18
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
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
this.FeatureBackgroundAsync();
#line hidden
#line 22
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 await testRunner.ThenAsync(string.Format("The result should be {0}", expectedText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Advanced")]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word&add=word\"", "\"without profanity ****\"", null)]
        [NUnit.Framework.TestCaseAttribute("\" This is test Input\"&add=Input\"", "\"This is test *****\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"without profanity word&add=word&fill_text=aaaa\"", "\"without profanity aaaa\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with unwanted word boner&fill_text=[replaced]\"", "\"with unwanted word [replaced]\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"COCK with unwanted word&fill_text=20charactercharacter\"", "\"20charactercharacter with unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with chink unwanted word&fill_char=-\"", "\"with ----- unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with dic unwanted word&fill_char=~\"", "\"with ~~~ unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"with dic unwanted word&fill_char=|\"", "\"with ||| unwanted word\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is Shit and that is ass&fill_text=____\"", "\"this is ____ and that is ____\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,vv\"", "\"** ** ** ** *** *** *** *** *** jjj **\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_Advanced(string inputText, string expectedText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedText", expectedText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Advanced", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
this.FeatureBackgroundAsync();
#line hidden
#line 37
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 await testRunner.ThenAsync(string.Format("The result should be {0}", expectedText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter out bad words from profanity lists_Error Handling")]
        [NUnit.Framework.TestCaseAttribute("\"      \"", "\"No Input\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is some test input&fill_text=long replacement text\"", "\"User Replacement Text Exceeds Limit of 20 Characters.\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,jjj,v" +
            "v\"", "\"User Black List Exceeds Limit of 10 Words.\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"this is some test input.&add=this is some test input.\"", "\"Invalid Characters in User Black List\"", null)]
        [NUnit.Framework.TestCaseAttribute(@"""The Olympic star has told the BBC he was given the name Mohamed Farah by those who flew him over from Djibouti. His real name is Hussein Abdi Kahin. He was flown over from the East African country aged nine by a woman he had never met, and then made to look after another family's children.""", "\"User Black List Exceeds Limit of 200 maximum characters in lengh.\"", null)]
        public async System.Threading.Tasks.Task FilterOutBadWordsFromProfanityLists_ErrorHandling(string inputText, string expectedText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputText", inputText);
            argumentsOfScenario.Add("expectedText", expectedText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter out bad words from profanity lists_Error Handling", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 54
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
this.FeatureBackgroundAsync();
#line hidden
#line 55
 await testRunner.GivenAsync(string.Format("The User entered text {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
 await testRunner.WhenAsync("The user Request Web Service using JSON Method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
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
#line 65
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
this.FeatureBackgroundAsync();
#line hidden
#line 66
    await testRunner.GivenAsync(string.Format("The User entered text check if containing profanity words {0}", inputText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 await testRunner.WhenAsync("The user Request Web Service for status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 await testRunner.ThenAsync(string.Format("The expected status is {0}", expectedStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
