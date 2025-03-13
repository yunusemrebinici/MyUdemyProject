using HotelProject.WebUI.Dtos.WorkLocationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class WorkLocationController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public WorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IActionResult> Index()
		{
			var client=_httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/WorkLocation");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultWorkLocationDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
