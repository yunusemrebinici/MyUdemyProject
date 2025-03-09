using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DtoLayer.AboutDtos;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class AboutManager : IAboutService

	{
		private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
		{
            _aboutDal = aboutDal;
        }

        public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public About TGetById(int id)
		{
			var values = _aboutDal.GetById(id);
			return values;
		}
		
		public List<About> TGetList()
		{
			var values =_aboutDal.GetList();
			return values;
		}

		public void TInsert(About t)
		{
			_aboutDal.Insert(t);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}

        public void TUpdateAboutWithDto(UpdateAboutDto updateAboutDto)
        {
			_aboutDal.UpdateAboutWithDto(updateAboutDto);
        }
    }
}
