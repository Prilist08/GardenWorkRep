using Microsoft.AspNetCore.Mvc;

namespace JannatGarder.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Photo()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }
    }
}
