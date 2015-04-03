using System.Web.Http;

namespace AspNet.Web.Api
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("api/status")]
        public IHttpActionResult Status()
        {
            return this.Ok("Im fine");
        }
    }
}
