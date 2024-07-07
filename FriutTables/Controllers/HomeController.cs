using FriutTables.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FriutTables.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
