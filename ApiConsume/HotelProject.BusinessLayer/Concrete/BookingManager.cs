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
        public void TDelete(Booking t)
        {
            _bookDal.Delete(t);
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
