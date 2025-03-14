using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IStaffDal:IGenericDal<Staff>
	{
		Task<int> GetStaffCount();

		Task<List<Staff>> GetLast4Staff();
	}
}
