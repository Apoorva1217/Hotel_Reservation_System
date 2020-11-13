﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public interface Contact
    {
        /// <summary>
        /// Add hotel names and rates
        /// </summary>
        public void AddHotelAndRate();

        /// <summary>
        /// Find cheapest hotel with rate
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        public void FindCheapestHotel(DateTime checkInDate, DateTime checkOutDate, string checkInDay);
    }
}
