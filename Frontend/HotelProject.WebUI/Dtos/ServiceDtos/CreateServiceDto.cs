using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDtos
{
	public class CreateServiceDto
	{

		[Required(ErrorMessage ="Bu Kısım Boş Geçilemez.")]

		public string ServiceIcon { get; set; }

		[Required(ErrorMessage ="Bu Kısım Boş Geçilemez.")]
		[StringLength(100,ErrorMessage ="Maximum 100 karakter içerebilir.")]
		public string Title { get; set; }

		[Required(ErrorMessage ="Bu Kısım Boş Geçilemez.")]
		[StringLength(500,ErrorMessage ="Maximum 500 Karakter İçerebilir.")]
		public string Description { get; set; }
	}
}
