using Microsoft.AspNetCore.Mvc;
using PasswordValidator.Interfaces;
using PasswordValidator.Models;
using PasswordValidator.Services;

namespace PasswordValidator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordService _service;

        public PasswordController(IPasswordService service)
        {
            _service = service;
        }
        

        [HttpPost]
        public IActionResult IsValid([FromBody] PasswordModel model)
        {
            var result = _service.VerifyPassword(model.Password);
            Console.WriteLine(model.Password);
            return Ok(result);
        }
    }
}
