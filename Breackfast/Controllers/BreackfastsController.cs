
using BreackfastDtos;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    public class BreackfastController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get(){
        var response = new BreakfastResponse(new Guid(), "", DateTime.Now,
             DateTime.Now, DateTime.Now, new List<string>(),new List<string>()); 
            return Ok(response );
        }
    }

}