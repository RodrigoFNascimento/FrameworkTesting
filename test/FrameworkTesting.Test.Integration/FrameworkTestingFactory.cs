using System.Web.Http;

namespace FrameworkTesting.Test.Integration;
public class FrameworkTestingFactory : IDisposable
{
    private const string BaseUrl = "https://localhost:44352/";
    private readonly HttpServer _server;
    private bool isDisposed;
    public HttpClient HttpClient;

    public FrameworkTestingFactory()
    {
        var config = new HttpConfiguration();
        WebApiConfig.Register(config);
        config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
        _server = new HttpServer(config);
        HttpClient = new HttpClient(_server)
        {
            BaseAddress = new Uri(BaseUrl)
        };
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (isDisposed) return;

        if (disposing)
        {
            HttpClient.Dispose();
            _server.Dispose();
        }

        isDisposed = true;
    }
}
