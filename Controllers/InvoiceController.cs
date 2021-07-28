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

namespace GarageManagementSystem.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Invoice
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Invoice.Include(i => i.Booking);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Invoice/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice
                .Include(i => i.Booking)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // GET: Invoice/Create
        public async Task<IActionResult> Create(string bookingId)
        {
            if (bookingId == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Customer)
                .Include(b => b.Vehicle)
                .Where(b => b.Id == bookingId)
                .FirstOrDefaultAsync();

            if (booking == null)
            {
                return NotFound();
            }

            var invoiceViewModel = new InvoiceViewModel
            {
                BookingId = bookingId,
                CustomerName = booking.Customer.Name,
                Phone = booking.Customer.PhoneNumber,
                Vehicle = booking.Vehicle.Make + " " + booking.Vehicle.Model,
                Licence = booking.Vehicle.Licence,
            };

            // ViewData["Service"] = _context.Service.ToList().Select(p => new SelectListItem
            // {
            //     Value = p.Id,
            //     Text = p.Name + " - $" + p.Value,
            // }).ToList();
            // ViewData["Part"] = _context.Part.ToList().Select(p => new SelectListItem
            // {
            //     Value = p.Id,
            //     Text = p.Name + " - $" + p.Value,
            // }).ToList();

            // ViewData["Service"] = new MultiSelectList(_context.Service.ToList(), "Id", "Name");
            return View(invoiceViewModel);
        }

        // POST: Invoice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookingId,CustomerName,Phone,Vehicle,Licence,Comment,Services,Parts")] InvoiceViewModel invoiceViewModel)
        {
            if (ModelState.IsValid)
            {
                var invoice = new Invoice
                {
                    Id = invoiceViewModel.Id,
                    BookingId = invoiceViewModel.BookingId,
                    CustomerName = invoiceViewModel.CustomerName,
                    Phone = invoiceViewModel.Phone,
                    Vehicle = invoiceViewModel.Vehicle,
                    Licence = invoiceViewModel.Licence,
                    Comment = invoiceViewModel.Comment,
                    //Services = _context.Service.Where(e => invoiceViewModel.Services.Contains(e.Id)).ToList(),
                };

                _context.Add(invoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(invoiceViewModel);
        }

        // GET: Invoice/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice
                //.Include(i => i.Services)
                .FirstOrDefaultAsync(i => i.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            var invoiceViewModel = new InvoiceViewModel
            {
                Id = invoice.Id,
                BookingId = invoice.BookingId,
                CustomerName = invoice.CustomerName,
                Phone = invoice.Phone,
                Vehicle = invoice.Vehicle,
                Licence = invoice.Licence,
                Comment = invoice.Comment,
            };

            return View(invoiceViewModel);
        }

        // POST: Invoice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,BookingId,CustomerName,Phone,Vehicle,Licence,Comment,Services,Parts")] InvoiceViewModel invoiceViewModel)
        {
            if (id != invoiceViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var invoice = new Invoice
                    {
                        Id = invoiceViewModel.Id,
                        BookingId = invoiceViewModel.BookingId,
                        CustomerName = invoiceViewModel.CustomerName,
                        Phone = invoiceViewModel.Phone,
                        Vehicle = invoiceViewModel.Vehicle,
                        Licence = invoiceViewModel.Licence,
                        Comment = invoiceViewModel.Comment,
                        //Services = _context.Service.Where(e => invoiceViewModel.Services.Contains(e.Id)).ToList(),
                    };
                    //_context.InvoiceService.RemoveRange(_context.InvoiceService.Where(i => i.InvoicesId == invoiceViewModel.Id));
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoiceViewModel.Id))
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

            return View(invoiceViewModel);
        }

        // GET: Invoice/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice
                .Include(i => i.Booking)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Invoice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var invoice = await _context.Invoice.FindAsync(id);
            _context.Invoice.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(string id)
        {
            return _context.Invoice.Any(e => e.Id == id);
        }
    }
}
