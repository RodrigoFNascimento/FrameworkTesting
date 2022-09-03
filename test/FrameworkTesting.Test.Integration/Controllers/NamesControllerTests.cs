using System.Net;

namespace FrameworkTesting.Test.Integration.Controllers;

[Collection("FrameworkTesting collection")]
public class NamesControllerTests
{
    private readonly FrameworkTestingFactory _fixture;
    private const string RoutePrefix = "Names";

    public NamesControllerTests(FrameworkTestingFactory fixture)
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
