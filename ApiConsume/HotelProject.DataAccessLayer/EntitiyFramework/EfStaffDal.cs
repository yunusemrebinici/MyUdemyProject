using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
	public class EfStaffDal :GenericRepository<Staff>,IStaffDal
	{
		private readonly Context _context;
        public EfStaffDal(Context context) :base (context)
        {
			_context = context;
        }

		public async Task<List<Staff>> GetLast4Staff()
		{
			return await _context.Staff.OrderByDescending(x=>x.StaffID).Take(3).ToListAsync();
		}

		public  async Task< int> GetStaffCount()
		{				
			return await _context.Staff.CountAsync();
		}
	}
}
