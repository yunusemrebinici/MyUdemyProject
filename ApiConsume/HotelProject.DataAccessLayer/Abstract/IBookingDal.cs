using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IBookingDal : IGenericDal<Booking>
	{
		void BookingAdminStatusTrue(int id);

		void BookingReservationCanceled(int id);

		void BookingWaitforReservation(int id);

		 Task<int> GetBookingCount();

	}
}
