using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UcgenAlaniHesaplamaWebApplication.Models;

namespace UcgenAlaniHesaplamaWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(UcgenAlanHesabi ucgenAlanHesabi)
        {
            var yukseklik = ucgenAlanHesabi.Yukseklik;
            var tabanUzunlugu = ucgenAlanHesabi.TabanUzunlugu;
            var alan=(yukseklik*tabanUzunlugu)/ 2;

            ViewBag.Message = "Üçgenin Alanı : " + alan;
            return View("ucgenAlanHesabi");
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