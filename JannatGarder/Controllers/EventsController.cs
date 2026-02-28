using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace JannatGarder.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WeddingAndReception()
        {
            return View();
        }
        public IActionResult EngagementAndRingCeremony()
        {
            return View();
        }
        public IActionResult BirthdayAndAnniversary()
        {
            return View();
        }
        public IActionResult CorporateEvents()
        {
            return View();
        }
    }
}
