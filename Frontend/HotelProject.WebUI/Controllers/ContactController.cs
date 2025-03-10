using HotelProject.WebUI.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult _AddContact()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> _AddContact(CreateContactDto createContact)
		{
			var jsonData = JsonConvert.SerializeObject(createContact);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.PostAsync("http://localhost:21924/api/Contact", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Contact");
			}
			return View();	
		}


	}
}
