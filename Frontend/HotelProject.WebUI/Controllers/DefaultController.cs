﻿using HotelProject.WebUI.Dtos.SubscribeDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
          
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task <IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto) 
        { 
            var values= JsonConvert.SerializeObject(createSubscribeDto);
            var client = _httpClientFactory.CreateClient();
            StringContent content = new StringContent(values,Encoding.UTF8,"application/json");
            await client.PostAsync("http://localhost:21924/api/Subscribe", content); 
            return RedirectToAction("Index","Default");
           
        }

	}
}
