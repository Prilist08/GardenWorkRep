using Microsoft.AspNetCore.Mvc;

namespace JannatGarder.Controllers
{
    public class VenuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GardenLawn()
        {
            return View();
        }
        public IActionResult ACBanquetHall()
        {
            return View();
        }
        public IActionResult SeatingLayouts()
        {
            return View();
        }

    }
}
