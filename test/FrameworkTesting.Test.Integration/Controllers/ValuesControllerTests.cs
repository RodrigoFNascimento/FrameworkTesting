using System.Net;

namespace FrameworkTesting.Test.Integration.Controllers;

[Collection("FrameworkTesting collection")]
public class ValuesControllerTests
{
    private readonly FrameworkTestingFactory _fixture;
    private const string RoutePrefix = "Values";

    public ValuesControllerTests(FrameworkTestingFactory fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Get_ShouldReturnOk_WhenRequestIsValid()
    {
        // Arrange


        // Act
        var result = await _fixture.HttpClient.GetAsync($"{RoutePrefix}/Get");

        // Assert
        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
    }
}