using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBooking(Booking booking)
        {
            _bookingService.TDelete(booking);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }

		[HttpGet("UpdateBooking")]
		public IActionResult UpdateBookingStatus(int id)
		{
			_bookingService.TBookingAdminStatusTrue(id);
			return Ok();

		}

		[HttpGet("ReservationCanceled")]
		public IActionResult ReservationCanceled(int id)
		{
			_bookingService.TBookingReservationCanceled(id);
			return Ok();

		}
		[HttpGet("ReservationWait")]
		public IActionResult ReservationWait(int id)
		{
			_bookingService.TBookingWaitforReservation(id);
			return Ok();

		}
		[HttpGet("GetLast4Booking")]
		public async Task< IActionResult> GetLast4Booking()
		{
			
			return Ok(await _bookingService.TGetLast4Booking());

		}
	}
}

