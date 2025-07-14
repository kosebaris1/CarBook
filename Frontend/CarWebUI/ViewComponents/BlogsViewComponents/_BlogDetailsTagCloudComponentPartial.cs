using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsTagCloudComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
