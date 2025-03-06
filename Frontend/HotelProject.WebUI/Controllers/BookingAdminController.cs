using HotelProject.WebUI.Dtos.BookingAdminDtos;
using HotelProject.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class BookingAdminController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public BookingAdminController(IHttpClientFactory httpClientFactory)

		{
			_httpClientFactory = httpClientFactory;

		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/Booking");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBookingAdminDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		
		public async Task<IActionResult>ApprovedStatus(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Booking/UpdateBooking?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index","BookingAdmin");
			}
			return View();

		}

		
		public async Task<IActionResult> CancelStatus(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Booking/ReservationCanceled?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "BookingAdmin");
			}
			return View();

		}

		public async Task<IActionResult> ReservationWait(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Booking/ReservationWait?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "BookingAdmin");
			}
			return View();

		}

	}
}
