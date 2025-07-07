using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
