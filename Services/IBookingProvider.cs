using System;
using System.Collections.Generic;

namespace GarageManagementSystem.Services
{
    public interface IBookingProvider
    {
        /// <summary>
        /// Generate a list of available spots for the next few days
        /// </summary>
        /// <returns>DatesAvailable</returns>
        List<DateTime> GetAvailabelDates();
    }
}