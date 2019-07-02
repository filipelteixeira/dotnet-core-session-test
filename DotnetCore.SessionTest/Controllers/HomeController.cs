using System.Diagnostics;
using System.Threading.Tasks;
using DotnetCore.SessionTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.SessionTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Session1"] = HttpContext.Session.GetString("Sesson1");
            ViewData["Session2"] = HttpContext.Session.GetInt32("Sesson2");
            return View();
        }

        public async Task<IActionResult> About()
        {
            HttpContext.Session.SetString("Sesson1", "Value 1");

            HttpContext.Session.SetInt32("Sesson2", 22);

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
