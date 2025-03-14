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
        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService)
        {
            _staffService = staffService;
			_bookingService = bookingService;
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

	}
}
