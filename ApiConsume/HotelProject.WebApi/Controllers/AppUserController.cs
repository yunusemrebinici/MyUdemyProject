using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult GetAppUserList()
        {
            return Ok (_appUserService.TGetList());
        }
        [HttpGet("GetAppUserListWithLocation")]
        public IActionResult GetAppUserListWithLocation()
        {
            return Ok(_appUserService.TUserListWithWorkLocation());
        }
    }
}
