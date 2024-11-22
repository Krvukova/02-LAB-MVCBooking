using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic; 

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> hotelBookings = new List<HotelBooking>();

        public IActionResult Index()
        {
            return View(hotelBookings);
        }

        public IActionResult Create()
        {
            HotelBooking hotelBooking = new HotelBooking(); 
            return View(hotelBooking); 
        }

        [HttpPost]
        public IActionResult CreateHotelBooking(HotelBooking hotelBookingViewModel)
        {
            hotelBookings.Add(hotelBookingViewModel);
            return RedirectToAction("Index");
        }


    }
}
