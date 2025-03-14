using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
	public class EfStaffDal :GenericRepository<Staff>,IStaffDal
	{
        public EfStaffDal(Context context) :base (context)
        {
                
        }

		public int GetStaffCount()
		{
			var context= new Context();
			var values = context.Staff.Count();
			return values;
		}
	}
}
