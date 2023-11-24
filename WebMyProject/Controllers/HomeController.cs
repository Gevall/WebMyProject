using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMyProject.Model;

namespace WebMyProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trips()
        {
            return View();
        }
    }
}
