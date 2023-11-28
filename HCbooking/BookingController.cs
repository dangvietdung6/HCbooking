using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HCbooking
{
    public class BookingController : Controller
    {
        private static List<Booking> bookings = new List<Booking>();

        public IActionResult Index()
        {
            return View(bookings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            booking.Id = bookings.Count + 1;
            bookings.Add(booking);
            return RedirectToAction("Index");
        }
    }
}