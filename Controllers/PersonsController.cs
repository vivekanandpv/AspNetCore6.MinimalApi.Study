using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6.MinimalApi.Study.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //  These tricks work, but are not recommended as they create unreasonable codebase
        //  Only for understanding purpose

        //  It is possible to use one action method with multiple routes
        //  But a route cannot have more than one action method (causes exception)
        [Route("bar")]
        [Route("foo")]
        [HttpGet("baz")]   //  Responds for HttpGet for bar, foo, and baz
        public IActionResult Get()
        {
            return Ok(new { Name = "John Doe" });
        }

        //  It is possible to create one action method which accepts multiple http methods
        //  methods are case insensitive
        //  can have non-standard methods!
        [Route("wild-card")]
        [AcceptVerbs("get", "post", "delete", "FOO")]  
        public IActionResult WildMethod()
        {
            return Ok(new { Message = "That was ok!" });
        }
    }
}
