using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }

        public PartialViewResult _SideBarAdminContactPartial()
        {
            return PartialView();
        }

		public PartialViewResult _SideBarAdminContactCategoryPartial()
		{
			return PartialView();
		}
	}
}
