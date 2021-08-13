using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GarageManagementSystem.Data;
using GarageManagementSystem.Models;
using GarageManagementSystem.ViewModels;
using GarageManagementSystem.Services;
using Microsoft.AspNetCore.Authorization;

namespace GarageManagementSystem.Controllers
{
    [Authorize(Roles="Customer")]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookingProvider _bookingProvider;

        public BookingController(ApplicationDbContext context, IBookingProvider bookingProvider)
        {
            _context = context;
            _bookingProvider = bookingProvider;
        }

        // GET: Booking
        public async Task<IActionResult> Index()
        {
            // Recover data of logged user from Database
            var user = _context.Users.Where(u => u.UserName == User.Identity.Name).First();
            var bookings = await _context.Booking.Include(b => b.Customer).Include(b => b.Vehicle)
                .Where(b=> b.CustomerId == user.Id).ToListAsync();
            return View(bookings);
        }

        // GET: Booking/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            booking.Vehicle = _context.Vehicle.First(v => v.Id == booking.VehicleId);

            return View(booking);
        }

        // GET: Booking/Create
        public IActionResult Create()
        {
            // Recover data of logged user from Database
            var user = _context.Users.Where(u => u.UserName == User.Identity.Name).First();
            // Recover Vehicle of the user
            user.Vehicles = _context.Vehicle.Where(v => v.CustomerId == user.Id).ToList();

            BookingViewModel bookingViewModel = new BookingViewModel
            {
                CustomerId = user.Id,
                Vehicles = user.Vehicles.Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Licence,
                }).ToList(),
                AvailableDates = _bookingProvider.GetAvailabelDates().Select(d => new SelectListItem
                {
                    Value = d.ToString(),
                    Text = d.ToString(),
                }).ToList(),
            };

            return View(bookingViewModel);
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,VehicleId,BookingType,Date,Comment")] BookingViewModel bookingViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var booking = new Booking
                    {
                        Customer = _context.Users.First(c => c.Id == bookingViewModel.CustomerId),
                        Vehicle = _context.Vehicle.First(v => v.Id == bookingViewModel.VehicleId),
                        BookingType = bookingViewModel.BookingType,
                        Date = bookingViewModel.Date,
                        Comment = bookingViewModel.Comment,
                    };
                    _context.Add(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (string.IsNullOrWhiteSpace(bookingViewModel.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookingViewModel);
        }

        // GET: Booking/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            // Recover data of logged user from Database
            var user = _context.Users.Where(u => u.UserName == User.Identity.Name).First();
            // Recover Vehicle of the user
            user.Vehicles = _context.Vehicle.Where(v => v.CustomerId == user.Id).ToList();
            // Create view model
            BookingViewModel bookingViewModel = new BookingViewModel
            {
                CustomerId = user.Id,
                VehicleId = booking.VehicleId,
                BookingType = booking.BookingType,
                Date = booking.Date,
                Comment = booking.Comment,
            };
            bookingViewModel.SetVehicles(user.Vehicles);
            bookingViewModel.SetAvailableDates(_bookingProvider.GetAvailabelDates());

            return View(bookingViewModel);
        }

        // POST: Booking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,CustomerId,VehicleId,BookingType,Date,Comment")] BookingViewModel bookingViewModel)
        {
            if (id != bookingViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var booking = new Booking
                    {
                        Id = bookingViewModel.Id,
                        CustomerId = bookingViewModel.CustomerId,
                        VehicleId = bookingViewModel.VehicleId,
                        BookingType = bookingViewModel.BookingType,
                        Date = bookingViewModel.Date,
                        Comment = bookingViewModel.Comment,
                    };
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(bookingViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookingViewModel);
        }

        // GET: Booking/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            booking.Vehicle = _context.Vehicle.First(v => v.Id == booking.VehicleId);

            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var booking = await _context.Booking.FindAsync(id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(string id)
        {
            return _context.Booking.Any(e => e.Id == id);
        }
    
    }
}
