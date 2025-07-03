using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
