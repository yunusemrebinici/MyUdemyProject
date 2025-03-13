using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkLocationController : ControllerBase
	{
		private readonly IWorkLocationService _workLocationService;
		public WorkLocationController(IWorkLocationService workLocationService)
		{
			_workLocationService = workLocationService;
		}

		[HttpGet]
		public async Task<IActionResult> GetWorkLocationList()
		{
			return Ok(_workLocationService.TGetList());
		}
	}
}
