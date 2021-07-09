using System;
using System.Collections.Generic;

namespace GarageManagementSystem.Services
{
    public class BookingProvider
    {
        private const DayOfWeek OPENNEXTWEEK = DayOfWeek.Thursday;
        private const DayOfWeek DAYGARAGECLOSED = DayOfWeek.Sunday;

        public List<DateTime> GetAvailabelDates()
        {
            var DatesAvailable = new List<DateTime>();
            var today = DateTime.Today;
            var targetDate = today;
            double numberDaysAvailable = today.DayOfWeek >= DayOfWeek.Thursday ? ((double)DAYGARAGECLOSED) + 7 + (7 - (double)today.DayOfWeek) : (7 - (double)today.DayOfWeek);
            while (targetDate < today.AddDays(numberDaysAvailable))
            {
                if (targetDate.DayOfWeek != DAYGARAGECLOSED)
                {
                    DatesAvailable.Add(targetDate);
                }
                targetDate = targetDate.AddDays(1);
            }

            return DatesAvailable;
        }
    }
}