using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
	public class EfRoomDal:GenericRepository<Room>,IRoomDal
	{
		private readonly Context _context;
        public EfRoomDal(Context context):base(context)
        {
            _context = context;
        }

		public async Task<int> GetRoomCount()
		{
			return await _context.Rooms.CountAsync();
		}
	}
}
