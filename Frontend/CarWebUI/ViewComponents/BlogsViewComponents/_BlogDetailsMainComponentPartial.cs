using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsMainComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // You can add any logic here if needed, such as fetching data from a service
            // For now, we will just return the view
            return View();
        }
    }
}
