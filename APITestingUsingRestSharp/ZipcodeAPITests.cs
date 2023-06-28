using System.Net;
using RestSharp;

namespace APITestingUsingRestSharp;

public class ZipcodeAPITests
{
    private RestClient client;

    [SetUp]
    public void Setup()
    {
        client = new RestClient("http://api.zippopotam.us");
    }

    [Test]
    public void Given_a_US_postcode_When_the_api_is_called_Then_it_should_return_an_HTTP_OK_response()
    {
        RestRequest request = new RestRequest("us/90210", Method.Get);

        RestResponse response = client.Execute(request);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(response.ContentType, Is.EqualTo("application/json"));
    }
}
