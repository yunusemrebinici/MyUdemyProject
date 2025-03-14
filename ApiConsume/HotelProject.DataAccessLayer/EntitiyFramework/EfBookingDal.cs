using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
    public class EfBookingDal:GenericRepository<Booking>,IBookingDal
    {
		private readonly Context _context;

		public EfBookingDal(Context context) : base(context)
		{
			_context = context;
		}

		public void BookingAdminStatusTrue(int id)
		{
			
            var values = _context.Bookings.Find(id);
            values.Status = "Onaylandı";
            _context.SaveChanges();
		}

		public void BookingReservationCanceled(int id)
		{
			
			var values = _context.Bookings.Find(id);
			values.Status = "İptal Edildi";
			_context.SaveChanges();
		}

		public void BookingWaitforReservation(int id)
		{
			
			var values = _context.Bookings.Find(id);
			values.Status = "Beklemede,Müşteri Aranacak";
			_context.SaveChanges();
		}

		public  async Task <int> GetBookingCount()
		{
					 
			return await _context.Bookings.CountAsync();
		}

		public async Task<List<Booking>> GetLast4Booking()
		{
			return await _context.Bookings.OrderByDescending(x=>x.BookingID).Take(4).ToListAsync();
		}
	}
}
