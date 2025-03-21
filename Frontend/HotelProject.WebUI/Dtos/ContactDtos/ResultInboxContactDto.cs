﻿using System;

namespace HotelProject.WebUI.Dtos.ContactDtos
{
	public class ResultInboxContactDto
	{
		public int ContactID { get; set; }

		public string Name { get; set; }

		public string Mail { get; set; }

		public string Subject { get; set; }

		public DateTime Date { get; set; }
	}
}
