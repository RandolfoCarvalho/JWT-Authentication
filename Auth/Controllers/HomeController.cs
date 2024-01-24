using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Acesse: /Auth/Profile para realizacao de login");
        }
        
    }
}
