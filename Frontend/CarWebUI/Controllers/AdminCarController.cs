using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
