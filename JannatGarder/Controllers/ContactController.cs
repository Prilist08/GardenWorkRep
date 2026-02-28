using Microsoft.AspNetCore.Mvc;

namespace JannatGarder.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
