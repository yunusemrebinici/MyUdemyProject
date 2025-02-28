﻿using HotelProject.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class ServiceController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;
		public ServiceController(IHttpClientFactory httpClientFactory)

		{
			_httpClientFactory = httpClientFactory;

		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/Service");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> AddService()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddService(CreateServiceDto createServiceDto)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createServiceDto);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PostAsync("http://localhost:21924/api/Service", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateService(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Service/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);
				return View(values);
			}
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateServiceDto);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:21924/api/Service", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult>DeleteService(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:21924/api/Service/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
