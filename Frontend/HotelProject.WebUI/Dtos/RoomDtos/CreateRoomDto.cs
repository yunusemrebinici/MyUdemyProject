﻿namespace HotelProject.WebUI.Dtos.RoomDtos
{
	public class CreateRoomDto
	{
		

		public string RoomNumber { get; set; }

		public string RoomCoverImage { get; set; }

		public int Price { get; set; }

		public string BedCount { get; set; }

		public string BatCount { get; set; }

		public string Description { get; set; }
	}
}
