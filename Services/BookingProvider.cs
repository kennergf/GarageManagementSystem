using System;
using System.Collections.Generic;
using System.Linq;
using GarageManagementSystem.Data;

namespace GarageManagementSystem.Services
{
    public class BookingProvider : IBookingProvider
    {
        private readonly ApplicationDbContext _context;
        
        /// <summary>
        /// Day that the booking for next week is made available
        /// </summary>
        private const DayOfWeek OPENNEXTWEEK = DayOfWeek.Thursday;

        /// <summary>
        /// Day of the week the garage is closed
        /// </summary>
        private const DayOfWeek DAYGARAGECLOSED = DayOfWeek.Sunday;

        /// <summary>
        /// Time of the day garage opens
        /// </summary>
        private const int TIMEGARAGEOPEN = 9;

        /// <summary>
        /// Duration of the work shift
        /// </summary>
        private const int WORKSHIFTDURATION = 8;

        public BookingProvider(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<DateTime> GetAvailabelDates()
        {
            var DatesAvailable = new List<DateTime>();
            var today = DateTime.Today;
            // Start at the time the garage open
            var targetDate = today.AddHours(TIMEGARAGEOPEN - today.Hour);
            // Number of days starting from today that will be available to the user
            double numberOfDaysAvailable = today.DayOfWeek >= OPENNEXTWEEK ? ((double)DAYGARAGECLOSED) + 7 + (7 - (double)today.DayOfWeek) : (7 - (double)today.DayOfWeek);
            List<DateTime> booked = _context.Booking.Where(b => b.Date >= today && b.Date <= today.AddDays(numberOfDaysAvailable + 1)).Select(b => b.Date).ToList();
            while (targetDate < today.AddDays(numberOfDaysAvailable))
            {
                if (targetDate.DayOfWeek != DAYGARAGECLOSED)
                {
                    // Add Booking spot with one hour between then
                    for (int i = 0; i < WORKSHIFTDURATION; i++)
                    {
                        if(!booked.Any(d => d == targetDate))
                        {
                            DatesAvailable.Add(targetDate);
                        }
                        targetDate = targetDate.AddHours(1);
                    }
                }
                // Update Date for next day when garage opens
                targetDate = targetDate.AddHours((24 - targetDate.Hour) + TIMEGARAGEOPEN);
            }

            return DatesAvailable;
        }
    }
}