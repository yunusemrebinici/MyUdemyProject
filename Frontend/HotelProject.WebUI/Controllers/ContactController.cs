using HotelProject.WebUI.Dtos.ContactDtos;
using HotelProject.WebUI.Dtos.MessageCategoryDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/MessageCategory");
			var jsonData= await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData);

			List<SelectListItem> category = (from y in values
											 select new SelectListItem
											 {
												 Text = y.MessageCategoryName,
												 Value=y.MessageCategoryID.ToString()
											 }).ToList();
			ViewBag.v=category;
											

			


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
