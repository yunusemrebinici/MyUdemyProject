﻿using HotelProject.WebUI.Dtos.StaffDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardLast4StaffList : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client =_httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/Staff/GetLast4Staff");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
