using NUnit.Framework.Internal;

namespace RestSharpNUnitTest;

public class RestSharpTest
{
    private string getUrl = "https://api.publicapis.org/entries";

   [Test]
    public void TestingConnection()
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest= new RestRequest(getUrl);
        var restResponse = restClient.Get(restRequest);
        Assert.AreEqual(true, restResponse.IsSuccessful);
    }

    [Test]
    public void TestingResponse() 
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest = new RestRequest(getUrl+"aa");
        var restResponse = restClient.Get(restRequest);
        var desired = "NotFound ";
        Assert.AreEqual(restResponse.StatusCode.ToString(), desired);
    }
}