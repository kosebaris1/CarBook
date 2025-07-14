using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.CommentViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
