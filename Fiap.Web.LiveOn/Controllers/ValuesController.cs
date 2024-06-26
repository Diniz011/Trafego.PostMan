using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.LiveOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("fiap");
        }

    }
}
