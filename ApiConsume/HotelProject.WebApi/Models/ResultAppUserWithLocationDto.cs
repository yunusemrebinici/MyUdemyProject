﻿namespace HotelProject.WebApi.Models
{
	public class ResultAppUserWithLocationDto
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string City { get; set; }

		public string ImageUrl { get; set; }

		public int WorkLocationID { get; set; }

		public string WorkLocationName { get; set; }

		public string WorkLocationCity { get; set; }
	}
}
