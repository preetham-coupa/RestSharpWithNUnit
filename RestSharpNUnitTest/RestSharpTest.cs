using NUnit.Framework.Internal;

namespace RestSharpNUnitTest;

public class RestSharpTest
{
    private string getUrl = "URL_TO_BE_REPLACED";

    [Test, Category("UnitTest")]
    public void TestingConnection()
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest = new RestRequest(getUrl);
        var restResponse = restClient.Get(restRequest);
        Assert.That(restResponse.IsSuccessful, Is.EqualTo(true));
    }

    [Test, Category("UnitTest")]
    public void TestingResponseFail()
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest = new RestRequest(getUrl + "aa");
        var restResponse = restClient.Get(restRequest);
        var desired = "NotFound";
        Assert.That(restResponse.StatusCode.ToString(), Is.EqualTo(desired));
    }

    [Test]
    public void TestingResponseSuccess()
    {
        RestClient restClient = new RestClient();
        RestRequest restRequest = new RestRequest(getUrl);
        var restResponse = restClient.Get(restRequest);
        var desired = "OK";
        Assert.AreEqual(restResponse.StatusCode.ToString(), desired);
    }
}