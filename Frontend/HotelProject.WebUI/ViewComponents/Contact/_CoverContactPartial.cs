using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Contact
{
	public class _CoverContactPartial : ViewComponent
	{
		public  IViewComponentResult Invoke() 
		{
			return View(); 
		}
	}
}
