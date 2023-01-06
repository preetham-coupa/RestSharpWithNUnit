using NUnit.Framework.Internal;

namespace RestSharpNUnitTest;

public class RestSharpTest
{
    private string getUrl = "https://api.publicapis.org/entries";

    [Test]
    public void Test1()
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest= new RestRequest(getUrl);
        var restResponse = restClient.Get(restRequest);
        Assert.AreEqual(true, restResponse.IsSuccessful);
    }
}