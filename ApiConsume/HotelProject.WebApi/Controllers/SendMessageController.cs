using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SendMessageController : ControllerBase
	{
		private readonly ISendMessageService _sendService;
        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendService = sendMessageService;
        }

		[HttpGet]
		public IActionResult SendMessageList()
		{
			var values = _sendService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddSendMessage(SendMessage SendMessage)
		{
			_sendService.TInsert(SendMessage);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteSendMessage(int id)
		{
			var values = _sendService.TGetById(id);
			_sendService.TDelete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateSendMessage(SendMessage SendMessage)
		{
			_sendService.TUpdate(SendMessage);
			return Ok();

		}

		[HttpGet("{id}")]
		public IActionResult GetSendMessage(int id)
		{
			var values = _sendService.TGetById(id);
			return Ok(values);
		}
	}
}
