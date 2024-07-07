using Microsoft.AspNetCore.Mvc;

namespace FriutTables.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
