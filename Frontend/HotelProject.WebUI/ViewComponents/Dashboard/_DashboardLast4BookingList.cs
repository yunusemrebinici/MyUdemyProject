using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardLast4BookingList:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();	
		}
	}
}
