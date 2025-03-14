using HotelProject.BusinessLayer.Models;
using HotelProject.DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        public List<AppUserWithLocationViewModel> TUserListWithWorkLocation();
    }
}
