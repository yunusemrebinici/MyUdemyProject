using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

		[HttpGet]
		public IActionResult GetContact()
		{
			return Ok(_contactService.TGetList());
		}

		[HttpPost]
		public IActionResult CreateContact(Contact contact)
		{
			contact.Date=DateTime.Now;
			_contactService.TInsert(contact);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetContactById(int id)
		{
			var values = _contactService.TGetById(id);
			return Ok(values);
		}
	}
}
