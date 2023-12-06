using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebMyProject.Model;

namespace WebMyProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private HttpClient client = new();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trips()
        {
            string url = @"https://localhost:44394/api/trips";

            string resultJson = client.GetStringAsync(url).Result;
            var trips = JsonConvert.DeserializeObject<List<Trips>>(resultJson);

            return View(trips);
        }
    }
}
