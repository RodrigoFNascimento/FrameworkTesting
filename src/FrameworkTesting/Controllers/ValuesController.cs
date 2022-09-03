using System.Web.Http;

namespace FrameworkTesting.Controllers
{
    [RoutePrefix("Values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
