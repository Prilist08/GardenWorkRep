using Microsoft.AspNetCore.Mvc;

namespace JannatGarder.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BanquetHall()
        {
            return View();
        }
        public IActionResult ThemeDecorations()
        {
            return View();
        }
        public IActionResult PremiumLighting()
        {
            return View();

        }
        public IActionResult SoundAndDJ()
        {
            return View();
        }
        public IActionResult CateringSupport()
        {
            return View();
        }
        public IActionResult EventManagement()
        {
            return View();
        }
    }
}
