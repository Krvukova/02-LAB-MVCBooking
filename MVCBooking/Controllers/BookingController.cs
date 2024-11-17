using Microsoft.AspNetCore.Mvc;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
