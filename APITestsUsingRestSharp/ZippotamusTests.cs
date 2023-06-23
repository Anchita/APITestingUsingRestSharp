namespace APITestsUsingRestSharp;
using RestSharp;
using NUnit.Framework;
using System.Net;

[TestFixture]
public class ZippotamusTests
{

    [Test]
    public void postcodeSearchTests()
    {
        RestClient client = new RestClient("http://api.zippopotam.us/us/90210");
        RestRequest request = new RestRequest("nl/3825", Method.Get);

        RestResponse response = client.Execute(request);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

    }

}

