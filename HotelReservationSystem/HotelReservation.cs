using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public string hotelName;
        public int rateForRegularCustomer;

        public HotelReservation(string hotelName, int rateForRegularCustomer)
        {
            this.hotelName = hotelName;
            this.rateForRegularCustomer = rateForRegularCustomer;
        }

        public string HotelName { get => this.hotelName; set => this.hotelName = value; }
        public int RateForRegularCustomer { get => this.rateForRegularCustomer; set => this.rateForRegularCustomer = value; }
    }
}
