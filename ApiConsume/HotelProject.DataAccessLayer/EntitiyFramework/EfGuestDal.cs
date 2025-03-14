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
    public class EfGuestDal:GenericRepository<Guest>,IGuestDal
    {
		private readonly Context _context;
        public EfGuestDal(Context context) :base(context) {
		
		_context = context;
		}



		public async Task<int> GetGuestCount()
		{
			return await _context.Guests.CountAsync();
		}
	}
}
