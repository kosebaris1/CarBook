using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeDriverComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
