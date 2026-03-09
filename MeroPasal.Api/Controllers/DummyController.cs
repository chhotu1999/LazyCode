using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeroPasal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        [HttpGet]
        public async Task<string> helloInterns()
        {
            return "hi buddy";
        }
    }
}
