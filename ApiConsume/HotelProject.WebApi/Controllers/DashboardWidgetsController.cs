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
        public DashboardWidgetsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

		[HttpGet("GetStaffCount")]
		public async Task<IActionResult> GetStaffCount()
		{
			return  Ok(_staffService.TGetStaffCount());
		}

	}
}
