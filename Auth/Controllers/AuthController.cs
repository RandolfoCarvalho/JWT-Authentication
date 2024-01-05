using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;

namespace Auth.Controllers
{
    public class AuthController : Controller
    {
        public async Task<IActionResult> Callback()
        {
            var result = await HttpContext.AuthenticateAsync(Auth0Constants.AuthenticationScheme);
            if(result.Succeeded)
            {
                return RedirectToAction(nameof(Profile), "Auth");
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize]
        public IActionResult Profile()
        {
            return Ok(new
            {
                Name = User.Identity.Name,
                EmailAddress = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                ProfileImage = User.Claims.FirstOrDefault(c => c.Type == "picture")?.Value
            });
        }
    }
}
