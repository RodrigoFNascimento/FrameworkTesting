using System.Web.Http;

namespace FrameworkTesting.Test.Integration;
public class FrameworkTestingFactory : IDisposable
{
    private const string _baseUrl = "https://localhost:44352/";
    private bool isDisposed;
    public HttpClient HttpClient;
    public HttpServer Server;

    public FrameworkTestingFactory()
    {
        var config = new HttpConfiguration();
        WebApiConfig.Register(config);
        config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
        Server = new HttpServer(config);
        HttpClient = new HttpClient(Server)
        {
            BaseAddress = new Uri(_baseUrl)
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
            Server.Dispose();
        }

        isDisposed = true;
    }
}
