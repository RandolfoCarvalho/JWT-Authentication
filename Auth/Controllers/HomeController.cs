using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Welcome()
        {
            return Ok("Welcome");
        }
    }
}
