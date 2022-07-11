using RestSharp;
using NUnit.Framework;


namespace HomeTrack_API
{ 
    class APITestProject1
    {
        [Test]
        public void ContentTestMethod1()
        {
            string inputText = "This is a shit";
            string expectedResult = "{\"result\":\"This is a ****\"}";

            // arrange
            RestClient client = new RestClient("https://www.purgomalum.com/");
            RestRequest request = new RestRequest("service/json?text=" + inputText, Method.Get);
            
            // act
            RestResponse response = client.Execute(request);

            // assert
            Assert.That(response.Content, Is.EqualTo(expectedResult));
        }



        [TestCase("It is a test.", "{\"result\":\"It is a test.\"}", TestName = "Check words not in profanity list")]
        [TestCase("Shit happens.", "{\"result\":\"**** happens.\"}", TestName = "Check words in profanity list")]
        [TestCase("SHIT HappenS.", "{\"result\":\"**** HappenS.\"}", TestName = "Check case sensitivity with words in profanity list")]
        [TestCase("but life goes on.&add=life&fill_char=_", "{\"result\":\"but ____ goes on.\"}", TestName = "Check add and fill_char optional parameters")]
        [TestCase("shit happens.&fill_text=Accident", "{\"result\":\"Accident happens.\"}", TestName = "Check fill_text optional parameter")]
        public void ContentTestMethod2(string inputText, string expectedResult)
        {
            // arrange
            RestClient client = new RestClient("https://www.purgomalum.com");
            RestRequest request = new RestRequest($"service/json?text= + {inputText }", Method.Get);

            // act
            RestResponse response = client.Execute(request);

           // assert
           Assert.That(response.Content, Is.EqualTo(expectedResult));
        }
    }
}

