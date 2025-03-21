﻿using HotelProject.WebUI.Dtos.ContactDtos;
using HotelProject.WebUI.Dtos.SendMessagesDtos;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
            var responseMessage2 = await client.GetAsync("http://localhost:21924/api/Contact/GetContactCount");
            var responseMessage3 = await client.GetAsync("http://localhost:21924/api/SendMessage/GetSendMessageCount");
            if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
				var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
				ViewBag.GetContactCount = jsonData2;
				ViewBag.GetSendMessageCount = jsonData3;
				var values = JsonConvert.DeserializeObject<List<ResultInboxContactDto>>(jsonData);
				return View(values);
			}

			return View();

		}

		[HttpGet]
		public async Task<IActionResult> SendBox()
		{
			var client =_httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:21924/api/SendMessage");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values =JsonConvert.DeserializeObject<List<ResultSendBoxContactDto>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> AddSendMessage()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddSendMessage(CreateSendMessage model)
		{
			model.SenderMail = "Admin@gmail.com";
			model.SenderName = "admin";
			model.Date = DateTime.Now;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:21924/api/SendMessage", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("SendBox");
			}

			return View();
		}

		[HttpGet]
		public async Task<IActionResult> SendBoxDetailById(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/SendMessage/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultSendBoxContactDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> InboxBoxDetailById(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:21924/api/Contact/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultInboxContactDto>(jsonData);
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
