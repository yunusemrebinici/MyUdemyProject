using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDtos
{
	public class UpdateRoomDto
	{
		public int RoomID { get; set; }


		[Required(ErrorMessage = "Lütfen Oda Numarasını Yazınız.")]

		public string RoomNumber { get; set; }

		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Lütfen Fiyat Bilgisini Giriniz.")]
		public int Price { get; set; }

		[Required(ErrorMessage = "Lütfen Yatak Sayısını Giriniz.")]
		public string BedCount { get; set; }

		[Required(ErrorMessage = "Lütfen Banyo Sayısını Giriniz.")]
		public string BatCount { get; set; }

		[Required(ErrorMessage ="Lütfen Açıklama Giriniz..")]
		[StringLength(100,ErrorMessage ="Lütfen En Fazla 100 Karakter Veri Girişi Yapınız.")]
		public string Description { get; set; }
	}
}
