using Microsoft.AspNetCore.Mvc;
using nldtDay03View.Models;
using System.Diagnostics;

namespace nldtDay03View.Controllers
{
    public class NldtHomeController : Controller
    {
        private readonly ILogger<NldtHomeController> _logger;

        public NldtHomeController(ILogger<NldtHomeController> logger)
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
        public IActionResult NldtAbout()

        {
            return View();
        }
        public IActionResult NldtViewIf()

        {
            return View();
        }
        public IActionResult NldtViewLoop()

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
