using System;
using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;

namespace PurgoMalum_API.Steps
{
    [Binding]
    public class FilteringAndRemovingUnwantedTextSteps
    {
        RestRequest request;
        RestResponse response;
        RestClient client;

       
        [Given(@"A user setup the web server")]
        public void GivenAUserSetupTheWebServer()
        {
            //setup web server 
            client = new RestClient("https://www.purgomalum.com/");
        }

        [Given(@"The User entered text ""(.*)""")]
        public void GivenTheUserEnteredText(string inputText)
        {
            // arrange
            request = new RestRequest("service/json?text="+inputText, Method.Get);
        }
        [When(@"The user Request Web Service using JSON Method")]
        public void WhenTheUserRequestWebServiceUsingJSONMethod()
        {
            // act
            response = client.Execute(request);
        }
        
        [Then(@"The result should be ""(.*)""")]
        public void ThenTheResultShouldBeResultWithoutProfanityWord(string expectedText)
        {
            // assert
            string returnedText = response.Content.Substring(11, response.Content.Length - 13);
            Assert.That(returnedText, Is.EqualTo(expectedText));
        }

        [Then(@"The error messages should be ""(.*)""")]
        public void ThenTheErrorMessagesShouldBe(string expectedError)
        {
            // assert
            string returnedText = response.Content.Substring(10, response.Content.Length - 12);
            Assert.That(returnedText, Is.EqualTo(expectedError));
        }

        [Given(@"The User entered text check if containing profanity words ""(.*)""")]
        public void GivenTheUserEnteredTextCheckIfContainingProfanityWords(string inputText)
        {
            // arrange
            request = new RestRequest("service/containsprofanity?text=" + inputText, Method.Get);
        }

        [When(@"The user Request Web Service for status")]
        public void WhenTheUserRequestWebServiceForStatus()
        {
            response = client.Execute(request);
        }


        [Then(@"The status should be ""(.*)""")]
        public void ThenTheStatusShouldBe(string expectedStatus)
        {
            Assert.That(response.IsSuccessful, Is.EqualTo(expectedStatus));
        }
    }
}
