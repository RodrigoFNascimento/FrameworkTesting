using FrameworkTesting.Controllers;
using System.Web.Http.Results;

namespace FrameworkTesting.Test.Unit.Controllers;
public class NamesControllerTests
{
    private readonly NamesController _sut;

    public NamesControllerTests()
    {
        _sut = new();
    }

    [Fact]
    public void Get_ShouldReturnOk_GivenValidRequest()
    {
        // Arrange
        Type expected = typeof(OkResult);

        // Act
        var result = _sut.Get();

        // Assert
        Assert.Equal(expected, result.GetType());
    }
}
