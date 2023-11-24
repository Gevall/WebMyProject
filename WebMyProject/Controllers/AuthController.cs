using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WebMyProject.UserAuth;

namespace WebMyProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _singInManager;


        [HttpGet]
        public IActionResult Login(string _retunrUrl)
        {
            return View(new UserLogin()
            {
                returnUrl = _retunrUrl
            });
        }
         
        [HttpPost]
        public async Task<IActionResult> Login(UserLogin login)
        {
            Debug.WriteLine($">>>>>>>>>>>> Auth request from: {login.email}"); // Строка вывода в консоль запроса на авторизацию

            // Поиск пользователя в БД
            UserLogin? authUser = Program.usersForTest.FirstOrDefault(p => 
            p.email ==  login.email && p.password == login.password);

            // Если пользователь не найден преброс на страницу
            if (authUser == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, login.email) };
            ClaimsIdentity identity = new ClaimsIdentity(claims, "Cookies");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
    }
}
