﻿using System;

namespace HotelProject.WebUI.Dtos.Contact
{
    public class CreateContactDto
    {

		public string Name { get; set; }

		public string Mail { get; set; }

		public string Subject { get; set; }

		public DateTime Date { get; set; }
	}
}
