using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Models;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntitiyFramework;
using HotelProject.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUser)
        {
            _appUserDal = appUser;
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
           return _appUserDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

		public List<AppUserWithLocationViewModel> TUserListWithWorkLocation()
		{
			return _appUserDal.UserListWithWorkLocation().Select(x=> new AppUserWithLocationViewModel
            {
                Name = x.Name,
                Surname = x.Surname,
                City = x.City,
                ImageUrl = x.ImageUrl,
                WorkLocationCity = x.WorkLocationCity,
                WorkLocationName = x.WorkLocationName,
                WorkLocationID = x.WorkLocationID,
                Country = x.Country,
                Gender= x.Gender,

            }).ToList();
		}
	}
}
