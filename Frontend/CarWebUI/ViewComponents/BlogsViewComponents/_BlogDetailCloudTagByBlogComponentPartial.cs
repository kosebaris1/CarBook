using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Here you can add logic to fetch cloud tags related to the blog
            // For now, we will just return the view without any data

            return View();
        }
    }
}
