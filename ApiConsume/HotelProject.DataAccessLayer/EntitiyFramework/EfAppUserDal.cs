using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Models;
using HotelProject.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {

        public EfAppUserDal(Context context) : base(context) { }


        public List<AppUserWithLocationViewModelDal> UserListWithWorkLocation()
        {
            var context = new Context();
	 
           var values = context.Users.Include(x => x.WorkLocation).Select(y=> new AppUserWithLocationViewModelDal
           {
               Name = y.Name,
               Surname = y.Surname,
               City = y.City,
               ImageUrl = y.ImageUrl,
               WorkLocationID = y.WorkLocationID,
               WorkLocationName= y.WorkLocation.WorkLocationName,
               WorkLocationCity= y.WorkLocation.WorkLocationCity,
               Country = y.Country,
               Gender = y.Gender,
           });
            return values.ToList();
        }
    }
}
