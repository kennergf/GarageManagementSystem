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
using Microsoft.AspNetCore.Authorization;

namespace GarageManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator,Mechanic")]
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
                .Include(i => i.InvoiceServices)
                .Include(i => i.InvoiceParts)
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
                    //Id = invoiceViewModel.Id,
                    BookingId = invoiceViewModel.BookingId,
                    CustomerName = invoiceViewModel.CustomerName,
                    Phone = invoiceViewModel.Phone,
                    Vehicle = invoiceViewModel.Vehicle,
                    Licence = invoiceViewModel.Licence,
                    Comment = invoiceViewModel.Comment,
                    //Services = _context.Service.Where(e => invoiceViewModel.Services.Contains(e.Id)).ToList(),
                };

                try
                {
                    var booking = _context.Booking.Find(invoiceViewModel.BookingId);
                    // TODO Validate

                    if (!booking.SetStatus(Enums.Status.FixedCompleted))
                    {
                        return View(invoiceViewModel);
                    }
                    _context.Add(invoice);
                    // Set Id to return to Details
                    invoiceViewModel.Id = invoice.Id;
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(invoiceViewModel.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = invoiceViewModel.Id });
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
            // TODO
            var invoice = await _context.Invoice.FindAsync(id);
            _context.Invoice.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddService(string id)
        {
            if (id == null || !InvoiceExists(id))
            {
                return NotFound();
            }

            var invoiceService = new InvoiceServiceViewModel
            {
                InvoiceId = id,
            };

            ViewData["Id"] = id;
            // REF https://www.aspsnippets.com/Articles/Implement-Grouped-DropDownList-using-OptGroup-in-ASPNet-MVC.aspx
            ViewData["Service"] = _context.Service.OrderBy(s => s.Name).ToList().Select(p => new SelectListItem
            {
                Value = p.Id,
                Text = p.Name + " - $" + p.Value,
                Group = new SelectListGroup() { Name = "Service" },
            }).ToList();

            ViewBag.OptService = new SelectList(_context.Service.OrderBy(s => s.Name).ToList(), "Id", "Name", null, "Group");

            return View(invoiceService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddService(string id, [Bind("Id,InvoiceId,ServiceId,Quantity")] InvoiceServiceViewModel invoiceServiceViewModel)
        {
            if (ModelState.IsValid)
            {
                var service = _context.Service.Find(invoiceServiceViewModel.ServiceId);
                var invoiceService = new InvoiceService
                {
                    InvoiceId = invoiceServiceViewModel.InvoiceId,
                    Name = service.Name,
                    Value = service.Value,
                    Quantity = invoiceServiceViewModel.Quantity,
                };
                await _context.AddAsync(invoiceService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = id });
            }

            return View(invoiceServiceViewModel);
        }

        public async Task<IActionResult> DeleteInvoiceService(string id, string invoiceServiceId)
        {
            var invoiceService = await _context.InvoiceService.FindAsync(invoiceServiceId);
            _context.InvoiceService.Remove(invoiceService);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = id });
        }

        public IActionResult AddPart(string id)
        {
            if (id == null || !InvoiceExists(id))
            {
                return NotFound();
            }

            var invoicePart = new InvoicePartViewModel
            {
                InvoiceId = id,
            };

            ViewData["Id"] = id;
            ViewData["Part"] = _context.Part.OrderBy(s => s.Name).ToList().Select(p => new SelectListItem
            {
                Value = p.Id,
                Text = p.Name + " - $" + p.Value,
                Group = new SelectListGroup() { Name = "Part" },
            }).ToList();

            ViewBag.OptPart = new SelectList(_context.Part.OrderBy(s => s.Name).ToList(), "Id", "Name", null, "Group");

            return View(invoicePart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPart(string id, [Bind("Id,InvoiceId,PartId,Quantity")] InvoicePartViewModel invoicePartViewModel)
        {
            if (ModelState.IsValid)
            {
                var part = _context.Part.Find(invoicePartViewModel.PartId);
                var invoicePart = new InvoicePart
                {
                    InvoiceId = invoicePartViewModel.InvoiceId,
                    Name = part.Name,
                    Value = part.Value,
                    Quantity = invoicePartViewModel.Quantity,
                };
                await _context.AddAsync(invoicePart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = id });
            }

            return View(invoicePartViewModel);
        }

        public async Task<IActionResult> DeleteInvoicePart(string id, string invoicePartId)
        {
            var invoicePart = await _context.InvoicePart.FindAsync(invoicePartId);
            _context.InvoicePart.Remove(invoicePart);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = id });
        }

        public async Task<IActionResult> PrintInvoice(string id)
        {
            var invoice = await _context.Invoice.Include(i => i.InvoiceServices).Include(i => i.InvoiceParts)
                .FirstOrDefaultAsync(i => i.Id == id);

            var printInvoiceViewModel = new PrintInvoiceViewModel
            {
                Id = invoice.Id,
                BookingId = invoice.BookingId,
                CustomerName = invoice.CustomerName,
                Phone = invoice.Phone,
                Vehicle = invoice.Vehicle,
                Licence = invoice.Licence,
                Comment = invoice.Comment,
                InvoiceServices = invoice.InvoiceServices,
                InvoiceParts = invoice.InvoiceParts,
            };

            return View(printInvoiceViewModel);
        }

        private bool InvoiceExists(string id)
        {
            return _context.Invoice.Any(e => e.Id == id);
        }

        private bool BookingExists(string id)
        {
            return _context.Booking.Any(e => e.Id == id);
        }
    }
}
