using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrentTimeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            List<string> list = new List<string>() 
            {
                new string("Nelson"),
                new string("Isaac"),
                new string("maidely")
            };

            return list;
        }
    }
}
