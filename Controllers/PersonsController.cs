using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6.MinimalApi.Study.Controllers
{
    //  This is the controller request path
    //  It's a good practice to version the APIs
    //  in the route template, [controller] means
    //  the name of the controller except Controller suffix (persons in the case)
    [Route("api/v1/[controller]")]
    [ApiController] //  This provides automatic serialization of objects as Json
    public class PersonsController : ControllerBase
    {
        //  controller has action methods
        [Route("foo")]  //  additional path for the action method (api/v1/persons/foo)
        [HttpGet]   //  Responds for HttpGet
        public IActionResult Get()
        {
            return Ok(new { Name = "John Doe" });
        }
    }
}
