﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Models
{
	public class AppUserWithLocationViewModel
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string City { get; set; }

		public string ImageUrl { get; set; }

		public int WorkLocationID { get; set; }

		public string WorkLocationName { get; set; }

		public string WorkLocationCity { get; set; }

		public string Gender { get; set; }

		public string Country { get; set; }
	}
}
