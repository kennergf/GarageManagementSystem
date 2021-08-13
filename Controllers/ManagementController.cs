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
using GarageManagementSystem.Enums;

namespace GarageManagementSystem.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookingProvider _bookingProvider;

        public ManagementController(ApplicationDbContext context, IBookingProvider bookingProvider)
        {
            _context = context;
            _bookingProvider = bookingProvider;
        }

        // GET: Management
        public async Task<IActionResult> Index(DateTime InitialDate, DateTime FinalDate)
        {
            var bookings = await _context.Booking.Include(b => b.Customer).Include(b => b.Vehicle).ToListAsync();

            // Filter only if Date is from one years backward or forward
            if (InitialDate.Year > 2020 && InitialDate > DateTime.Today.AddYears(-1))
            {
                bookings = bookings.Where(b => b.Date >= InitialDate).ToList();
            }
            if (FinalDate.Year > 2020 && FinalDate < DateTime.Today.AddYears(1))
            {
                bookings = bookings.Where(b => b.Date <= FinalDate).ToList();
            }

            var rosterings = new List<RosteringBookingViewModel>();
            bookings.ForEach(booking => rosterings.Add(new RosteringBookingViewModel
            {
                Id = booking.Id,
                CustomerName = booking.Customer.Name,
                VehicleLicence = booking.Vehicle.Licence,
                BookingType = booking.BookingType,
                Date = booking.Date,
                Status = booking.Status,
                Comment = booking.Comment,
                Vehicles = _context.Vehicle.Where(v => v.Id == booking.CustomerId).Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Licence,
                }).ToList(),
                AvailableDates = _bookingProvider.GetAvailabelDates().Select(d => new SelectListItem
                {
                    Value = d.ToString(),
                    Text = d.ToString(),
                }).ToList(),
                Mechanics = _context.Users.ToList().Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Name,
                }).ToList(),
                MechanicName = booking.Mechanic?.Name,
            }));

            // REF https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-search
            ViewBag.InitialDate = InitialDate;
            ViewBag.FinalDate = FinalDate;
            return View(rosterings);
        }

        // GET: PrintSchedule
        public async Task<IActionResult> PrintSchedule(DateTime InitialDate, DateTime FinalDate)
        {
            var bookings = await _context.Booking.Include(b => b.Customer).Include(b => b.Vehicle).ToListAsync();

            // Filter only if Date is from one years backward or forward
            if (InitialDate.Year > 2020 && InitialDate > DateTime.Today.AddYears(-1))
            {
                bookings = bookings.Where(b => b.Date >= InitialDate).ToList();
            }
            if (FinalDate.Year > 2020 && FinalDate < DateTime.Today.AddYears(1))
            {
                bookings = bookings.Where(b => b.Date <= FinalDate).ToList();
            }

            var rosterings = new List<RosteringBookingViewModel>();
            bookings.ForEach(booking => rosterings.Add(new RosteringBookingViewModel
            {
                Id = booking.Id,
                CustomerName = booking.Customer.Name,
                VehicleLicence = booking.Vehicle.Licence,
                MechanicName = booking.Mechanic?.Name,
                BookingType = booking.BookingType,
                Date = booking.Date,
                Status = booking.Status,
                Comment = booking.Comment,
                Vehicles = _context.Vehicle.Where(v => v.Id == booking.CustomerId).Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Licence,
                }).ToList(),
                AvailableDates = _bookingProvider.GetAvailabelDates().Select(d => new SelectListItem
                {
                    Value = d.ToString(),
                    Text = d.ToString(),
                }).ToList(),
                Mechanics = _context.Users.ToList().Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Name,
                }).ToList(),
            }));

            // REF https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-search
            ViewBag.InitialDate = InitialDate;
            ViewBag.FinalDate = FinalDate;
            return View(rosterings);
        }

        // GET: Management/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Customer)
                .Include(b => b.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Management/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id");
            return View();
        }

        // POST: Management/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,VehicleId,BookingType,Date,Comment")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id", booking.CustomerId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", booking.VehicleId);
            return View(booking);
        }

        // GET: Management/Edit/5
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
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Name", booking.CustomerId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Licence", booking.VehicleId);
            ViewData["MechanicId"] = new SelectList(_context.Users
                .Join(_context.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
                .Join(_context.Roles, r => r.ur.RoleId, ro => ro.Id, (r, ro) => new { r, ro })
            .Where(us => us.ro.NormalizedName == "MECHANIC"), "Id", "Name", booking.MechanicId);

            var rosteringBookingViewModel = new RosteringBookingViewModel
            {
                CustomerId = booking.CustomerId,
                VehicleId = booking.VehicleId,
                MechanicId = booking.MechanicId,
                BookingType = booking.BookingType,
                Date = booking.Date,
                Status = booking.Status,
                Comment = booking.Comment,
                Vehicles = _context.Vehicle.Where(v => v.CustomerId == booking.CustomerId).Select(v => new SelectListItem
                {
                    Value = v.Id,
                    Text = v.Licence,
                }).ToList(),
                AvailableDates = _bookingProvider.GetAvailabelDates().Select(d => new SelectListItem
                {
                    Value = d.ToString(),
                    Text = d.ToString(),
                }).ToList(),
                // REF https://stackoverflow.com/questions/22907820/lambda-expression-join-multiple-tables-with-select-and-where-clause
                // Make a Join between the tables Users, UserRoles and Roles to get only Users With the Role MECHANIC
                Mechanics = _context.Users
                .Join(_context.UserRoles, u => u.Id, ur => ur.UserId, (u, ur) => new { u, ur })
                .Join(_context.Roles, r => r.ur.RoleId, ro => ro.Id, (r, ro) => new { r, ro })
                .Where(us => us.ro.NormalizedName == "MECHANIC").ToList().Select(v => new SelectListItem
                {
                    Value = v.r.u.Id,
                    Text = v.r.u.Name,
                }).ToList(),
            };

            return View(rosteringBookingViewModel);
        }

        // POST: Management/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,CustomerId,VehicleId,MechanicId,BookingType,Date,Status,Comment")] RosteringBookingViewModel rosteringBookingViewModel)
        {
            if (id != rosteringBookingViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var booking = await _context.Booking.FindAsync(rosteringBookingViewModel.Id);
                    booking.MechanicId = rosteringBookingViewModel.MechanicId;
                    booking.BookingType = rosteringBookingViewModel.BookingType;
                    booking.Date = rosteringBookingViewModel.Date;
                    //booking.Status = rosteringBookingViewModel.Status;
                    booking.Comment = rosteringBookingViewModel.Comment;

                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(rosteringBookingViewModel.Id))
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
            //ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "UserName", User.Identity.Name);
            // ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", booking.VehicleId);
            return View(rosteringBookingViewModel);
        }

        public async Task<IActionResult> ChangeStatus(string id, Status status)
        {
            var booking = await _context.Booking.FindAsync(id);
            if (!booking.SetStatus(status))
            {
                throw new System.Exception("Status not updated! Check the actual status and Mechanic allocated");
            }
            _context.Update(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Management/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Customer)
                .Include(b => b.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Management/Delete/5
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
