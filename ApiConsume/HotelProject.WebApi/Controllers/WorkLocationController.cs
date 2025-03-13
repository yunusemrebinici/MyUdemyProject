using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
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

		[HttpPost]
		public IActionResult AddWorkLocation(WorkLocation WorkLocation)
		{
			_workLocationService.TInsert(WorkLocation);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteWorkLocation(int id)
		{
			var values = _workLocationService.TGetById(id);
			_workLocationService.TDelete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateWorkLocation(WorkLocation WorkLocation)
		{
			_workLocationService.TUpdate(WorkLocation);
			return Ok();

		}

		[HttpGet("{id}")]
		public IActionResult GetWorkLocation(int id)
		{
			var values = _workLocationService.TGetById(id);
			return Ok(values);
		}
	}
}
