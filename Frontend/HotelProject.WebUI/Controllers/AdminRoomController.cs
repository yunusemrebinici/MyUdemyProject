﻿using HotelProject.WebUI.Dtos.AboutDtos;
using HotelProject.WebUI.Dtos.ContactDtos;
using HotelProject.WebUI.Dtos.RoomDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21924/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }

            return View();
        }

		[HttpGet]
		public async Task<IActionResult> UpdateRoom(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Room/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateRoomDto>(jsonData);
				return View(values);

			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateRoom(UpdateRoomDto model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:21924/api/Room", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}

		[HttpGet]
		public PartialViewResult AddRoom()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> AddRoom(CreateRoomDto room)
		{
			var jsonData = JsonConvert.SerializeObject(room);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.PostAsync("http://localhost:21924/api/Room", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:21924/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
