using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class AuthController : Controller
    {
        public async Task<IActionResult> Callback()
        {
            var result = await HttpContext.AuthenticateAsync(Auth0Constants.AuthenticationScheme);
            if(result.Succeeded)
            {
                return RedirectToAction("Welcome", "Home");
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
