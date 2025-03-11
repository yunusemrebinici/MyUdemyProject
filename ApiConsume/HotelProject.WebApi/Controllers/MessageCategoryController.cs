using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageCategoryController : ControllerBase
	{
		private readonly IMessageCategoryService _messageCategoryService;

		public MessageCategoryController(IMessageCategoryService messageCategoryService)
		{
			_messageCategoryService = messageCategoryService;
		}

		[HttpGet]
		public IActionResult GetMessageCategoryList()
		{
			return Ok(_messageCategoryService.TGetList());
		}
	}
}
