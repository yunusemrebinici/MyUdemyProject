using System;

namespace HotelProject.WebUI.Dtos.BookingDtos
{
	public class ResultLast4BookingDto
	{
		public int BookingID { get; set; }

		public string Name { get; set; }

		public string Status { get; set; }

		public string Mail { get; set; }

		public DateTime Checkin { get; set; }

		public DateTime CheckOut { get; set; }

		public string Country { get; set; }

		public string City { get; set; }
	}
}
