using Microsoft.AspNetCore.Mvc;

namespace JannatGarder.Controllers
{
    public class EnquiryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
