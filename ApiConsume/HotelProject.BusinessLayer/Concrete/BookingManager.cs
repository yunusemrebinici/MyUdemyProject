using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookDal = bookingDal;
        }

		public async Task<List<Booking>> TGetLast4Booking()
		{
			return await _bookDal.GetLast4Booking();
		}

		public void TBookingAdminStatusTrue(int id)
		{
			_bookDal.BookingAdminStatusTrue(id);
		}

		public void TBookingReservationCanceled(int id)
		{
			_bookDal.BookingReservationCanceled(id);

		}

		public void TBookingWaitforReservation(int id)
		{
            _bookDal.BookingWaitforReservation(id);
		}

		public void TDelete(Booking t)
        {
            _bookDal.Delete(t);
        }

		public async Task<int> TGetBookingCount()
		{
			return   await _bookDal.GetBookingCount();
		}

		public Booking TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public List<Booking> TGetList()
        {
           return _bookDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bookDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookDal.Update(t);
        }
    }
}
