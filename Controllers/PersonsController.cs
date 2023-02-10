using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6.MinimalApi.Study.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //  Route template can be provided with method
        [HttpGet("foo")]
        public IActionResult Get()
        {
            return Ok(new { Name = "John Doe" });
        }

        //  route template with int constraint
        [HttpGet("by-id/{id:int}")]
        public IActionResult Get(int id)    //  parameter should be called id
        {
            return Ok(new { Name = "John Doe", Id = id });
        }

        //  route template with string constraint (default)
        [HttpGet("by-name/{name}")]
        public IActionResult Get(string name)    //  parameter should be called id
        {
            return Ok(new { Name = name, Id = 100 });
        }

        //  Route constraints: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-7.0#route-constraints
        
        //  Warning: Don't use constraints for input validation. If constraints are
        //  used for input validation, invalid input results in a 404 Not Found response.
        //  Invalid input should produce a 400 Bad Request with an appropriate error message.
        //  Route constraints are used to disambiguate similar routes, not to validate the
        //  inputs for a particular route.
    }
}
