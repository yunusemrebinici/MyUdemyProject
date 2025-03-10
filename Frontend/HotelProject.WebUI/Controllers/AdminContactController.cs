using HotelProject.WebUI.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller

    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task< IActionResult> Inbox()
        {
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/Contact");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultInboxContactDto>>(jsonData);
				return View(values);
			}

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
