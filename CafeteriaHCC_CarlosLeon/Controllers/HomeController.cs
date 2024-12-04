using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CafeteriaHCC_CarlosLeon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CafeteriaHCC_CarlosLeon.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBCAFETERIAHCCContext _DBContext;

        public HomeController(DBCAFETERIAHCCContext context)
        {
            _DBContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
