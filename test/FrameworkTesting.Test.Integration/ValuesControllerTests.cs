using System.Net;
using System.Web.Http;

namespace FrameworkTesting.Test.Integration;

public class ValuesControllerTests
{
    private readonly string _baseUrl = "https://localhost:44352/";
    private readonly HttpClient _httpClient;
    private readonly HttpServer _server;

    public ValuesControllerTests()
    {
        var config = new HttpConfiguration();
        WebApiConfig.Register(config);
        config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
        _server = new HttpServer(config);
        _httpClient = new HttpClient(_server)
        {
            BaseAddress = new Uri(_baseUrl)
        };
    }

    [Fact]
    public async Task Get_ShouldReturnOk_WhenRequestIsValid()
    {
        // Arrange
        

        // Act
        var result = await _httpClient.GetAsync("Values/Get");

        // Assert
        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
    }
}