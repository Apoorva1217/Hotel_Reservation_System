using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public string hotelName;
        public int weekdayRateForRegularCustomer;
        public int weekendRateForRegularCustomer;

        public HotelReservation(string hotelName, int weekdayRateForRegularCustomer, int weekendRateForRegularCustomer)
        {
            this.hotelName = hotelName;
            this.weekdayRateForRegularCustomer = weekdayRateForRegularCustomer;
            this.weekendRateForRegularCustomer = weekendRateForRegularCustomer;
        }

        public string HotelName { get => this.hotelName; set => this.hotelName = value; }
        public int WeekdayRateForRegularCustomer { get => this.weekdayRateForRegularCustomer; set => this.weekdayRateForRegularCustomer = value; }
        public int WeekendRateForRegularCustomer { get => this.weekendRateForRegularCustomer; set => this.weekendRateForRegularCustomer = value; }
    }
}
