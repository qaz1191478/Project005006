using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult CustomPage()  // à¾ÔèÁË¹éÒ CustomPage
        {
            return View();  // àª×èÍÁâÂ§¡Ñº CustomPage.cshtml
        }

        public IActionResult Knowledge()
        {
            return View(); // àª×èÍÁâÂ§¡Ñº Knowledge.cshtml
        }

        // áÊ´§à¹×éÍËÒº·¤ÇÒÁ 1-9
        public IActionResult ArticleDetail(int id)
        {
            if (id < 1 || id > 9)
            {
                return NotFound(); // »éÍ§¡Ñ¹¡ÒÃà¢éÒ¶Ö§º·¤ÇÒÁ·ÕèäÁèÁÕ
            }

            ViewData["ArticleId"] = id;
            return View($"ArticleDetail{id}");
        }

        public IActionResult ContactPage()
        {
            return View("_ContactPage");  // ª×èÍä¿Åì·Õè¤Ø³ÊÃéÒ§
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
