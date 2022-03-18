using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksWebSite.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(string username, string password, string ReturnURL)
        {

            if (username == "admin")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnURL == null ? "/Books/" : ReturnURL);
            }
            return Page();
        }
    }
}
