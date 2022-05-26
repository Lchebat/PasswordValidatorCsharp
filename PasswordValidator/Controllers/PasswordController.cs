using Microsoft.AspNetCore.Mvc;
using PasswordValidator.Models;

namespace PasswordValidator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {

        

        [HttpPost]
        public IActionResult IsValid([FromBody] PasswordModel model)
        {
            Console.WriteLine(model.Password);
            return Ok(model.Password);
        }
    }
}
