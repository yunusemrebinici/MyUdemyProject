using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DashboardWidgetsController : ControllerBase
	{


		private readonly IStaffService _staffService;
		private readonly IBookingService _bookingService;
		private readonly IGuestService _guestService;
		private readonly IRoomService _roomService;
        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService , IGuestService guestService, IRoomService roomService)
        {
            _staffService = staffService;
			_bookingService = bookingService;
			_guestService = guestService;
			_roomService= roomService;
        }

		[HttpGet("GetStaffCount")]
		public async Task<IActionResult> GetStaffCount()
		{
			return  Ok(await _staffService.TGetStaffCount());
		}
		
		[HttpGet("GetBookingCount")]
		public async Task<IActionResult> GetBookingCount()
		{
			return  Ok( await _bookingService.TGetBookingCount());
		}

		[HttpGet("GetGuestCount")]
		public async Task<IActionResult> GetGuestCount()
		{
			return Ok( await _guestService.TGetGuestCount());
		}
		[HttpGet("GetRoomCount")]
		public async Task<IActionResult> GetRoomCount()
		{
			return Ok(await _roomService.TGetRoomCount());
		}


	}
}
