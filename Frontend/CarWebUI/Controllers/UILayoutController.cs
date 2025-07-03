using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
