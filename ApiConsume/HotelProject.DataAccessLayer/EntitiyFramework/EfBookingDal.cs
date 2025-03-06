using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
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
        public EfBookingDal(Context context) : base(context)
        {
            
        }

		public void BookingAdminStatusTrue(int id)
		{
			var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
		}

		public void BookingReservationCanceled(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "İptal Edildi";
			context.SaveChanges();
		}

		public void BookingWaitforReservation(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Beklemede,Müşteri Aranacak";
			context.SaveChanges();
		}
	}
}
