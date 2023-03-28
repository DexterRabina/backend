using backenddotnet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backenddotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly BookingDbContext _bookingDbContext;

        public BookingController(BookingDbContext bookingDbContext)
        {
            _bookingDbContext = bookingDbContext;
        }

        [HttpGet]
        [Route("GetBooking")]
        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _bookingDbContext.Bookings.ToListAsync();
        }

        [HttpPost]
        [Route("AddBooking")]
        public async Task<Booking> AddStudents(Booking objBooking)
        {
            _bookingDbContext.Bookings.Add(objBooking);
            await _bookingDbContext.SaveChangesAsync();
            return objBooking;
        }

        [HttpPatch]
        [Route("UpdateBooking/{id}")]
        public async Task<Booking> UpdateBooking(Booking objBooking)
        {
            _bookingDbContext.Entry(objBooking).State = EntityState.Modified;
            await _bookingDbContext.SaveChangesAsync();
            return objBooking;
        }

        [HttpDelete]
        [Route("DeleteBooking/{id}")]
        public bool DeleteBooking(int id)
        {
            bool a = false;
            var booking = _bookingDbContext.Bookings.Find(id);
            if (booking != null)
            {
                a = true;
                _bookingDbContext.Entry(booking).State = EntityState.Deleted;
                _bookingDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
