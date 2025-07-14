using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailSlideBarSearchBoxComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
