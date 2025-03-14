using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardWidgetPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task <IViewComponentResult> InvokeAsync() 	
		{
			var client = _httpClientFactory.CreateClient();

			#region StaffCount
			var staffResponseMessage = await client.GetAsync("http://localhost:21924/api/DashboardWidgets/GetStaffCount");
			var staffJsonData= await staffResponseMessage.Content.ReadAsStringAsync();
			var staffValues = JsonConvert.DeserializeObject(staffJsonData);
			ViewBag.staffValues = staffValues;
			#endregion

			#region bookingCount
			var bookingResponseMessage = await client.GetAsync("http://localhost:21924/api/DashboardWidgets/GetBookingCount");
			var bookingJsonData = await bookingResponseMessage.Content.ReadAsStringAsync();
			var bookingValues = JsonConvert.DeserializeObject(bookingJsonData);
			ViewBag.bookingValues = bookingValues;

			#endregion

			#region roomCount
			var roomResponseMessage = await client.GetAsync("http://localhost:21924/api/DashboardWidgets/GetRoomCount");
			var roomJsonData = await roomResponseMessage.Content.ReadAsStringAsync();
			var roomValues = JsonConvert.DeserializeObject(roomJsonData);
			ViewBag.roomValues = roomValues;

			#endregion

			#region guestCount
			var guestResponseMessage = await client.GetAsync("http://localhost:21924/api/DashboardWidgets/GetGuestCount");
			var guestJsonData = await guestResponseMessage.Content.ReadAsStringAsync();
			var guestValues = JsonConvert.DeserializeObject(guestJsonData);
			ViewBag.guestValues = guestValues;

			#endregion

			return View();
		
		}
	}
}
