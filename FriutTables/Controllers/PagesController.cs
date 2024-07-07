using Microsoft.AspNetCore.Mvc;

namespace FriutTables.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Chackout()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult Fourofourpage()
        {
            return View();
        }
    }
}
