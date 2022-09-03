using System.Web.Http;

namespace FrameworkTesting.Controllers
{
    [RoutePrefix("Names")]
    public class NamesController : ApiController
    {
        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}