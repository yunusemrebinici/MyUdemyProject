using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDtos
{
	public class AddRoomDto
	{

		[Required(ErrorMessage ="Oda Numarası Boş Geçilemez")]

		public string RoomNumber { get; set; }

		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage ="Fiyat Kısmı Boş Geçilemez")]

		public int Price { get; set; }

		[Required(ErrorMessage ="Bu Kısım Boş Geçilemez")]

		public string BedCount { get; set; }

		[Required(ErrorMessage = "Bu Kısım Boş Geçilemez")]

		public string BatCount { get; set; }

		[Required(ErrorMessage = "Bu Kısım Boş Geçilemez")]

		public string Description { get; set; }
	}
}
