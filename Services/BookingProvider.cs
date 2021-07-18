using System;
using System.Collections.Generic;

namespace GarageManagementSystem.Services
{
    public class BookingProvider
    {
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

        public List<DateTime> GetAvailabelDates()
        {
            var DatesAvailable = new List<DateTime>();
            var today = DateTime.Today;
            // Start at the time the garage open
            var targetDate = today.AddHours(TIMEGARAGEOPEN - today.Hour);
            // Number of days starting from today that will be available to the user
            double numberOfDaysAvailable = today.DayOfWeek >= OPENNEXTWEEK ? ((double)DAYGARAGECLOSED) + 7 + (7 - (double)today.DayOfWeek) : (7 - (double)today.DayOfWeek);
            while (targetDate < today.AddDays(numberOfDaysAvailable))
            {
                if (targetDate.DayOfWeek != DAYGARAGECLOSED)
                {
                    // Add Booking spot with one hour between then
                    for (int i = 0; i < WORKSHIFTDURATION; i++)
                    {
                        DatesAvailable.Add(targetDate);
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