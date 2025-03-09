using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestGuest;
        public GuestController(IGuestService guestGuest)
        {
            _guestGuest = guestGuest;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestGuest.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest Guest)
        {
            _guestGuest.TInsert(Guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestGuest.TGetById(id);
            _guestGuest.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest Guest)
        {
            _guestGuest.TUpdate(Guest);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestGuest.TGetById(id);
            return Ok(values);
        }
    }
}
