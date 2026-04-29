using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
