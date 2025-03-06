using System;

namespace HotelProject.WebUI.Dtos.BookingAdminDtos
{
	public class ResultBookingAdminDto
	{
		public int BookingID { get; set; }

		public string Name { get; set; }

		public DateTime Checkin { get; set; }

		public DateTime CheckOut { get; set; }

		public string SpecialRequest { get; set; }

		public string Status { get; set; }

	}
}
