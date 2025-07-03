using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
