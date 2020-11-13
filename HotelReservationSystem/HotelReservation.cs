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
        public int ratingsForHotel;
        public int totalPrice;
        public int weekdayRateForRewardCustomer;
        public int weekendRateForRewardCustomer;


        public HotelReservation(string hotelName, int weekdayRateForRegularCustomer, int weekendRateForRegularCustomer, int ratingsForHotel)
        {
            this.hotelName = hotelName;
            this.weekdayRateForRegularCustomer = weekdayRateForRegularCustomer;
            this.weekendRateForRegularCustomer = weekendRateForRegularCustomer;
            this.ratingsForHotel = ratingsForHotel;
        }

        public HotelReservation(int totalPrice, string hotelName, int ratingsForHotel)
        {
            this.totalPrice = totalPrice;
            this.hotelName = hotelName;
            this.ratingsForHotel = ratingsForHotel;
        }

        public HotelReservation(string hotelName, int weekdayRateForRewardCustomer, int weekendRateForRewardCustomer)
        {
            this.hotelName = hotelName;
            this.weekdayRateForRewardCustomer = weekdayRateForRewardCustomer;
            this.weekendRateForRewardCustomer = weekendRateForRewardCustomer;
        }

        public string HotelName { get => this.hotelName; set => this.hotelName = value; }
        public int WeekdayRateForRegularCustomer { get => this.weekdayRateForRegularCustomer; set => this.weekdayRateForRegularCustomer = value; }
        public int WeekendRateForRegularCustomer { get => this.weekendRateForRegularCustomer; set => this.weekendRateForRegularCustomer = value; }
        public int RatingsForHotel { get => this.ratingsForHotel; set => this.ratingsForHotel = value; }
        public int TotalPrice { get => this.totalPrice; set => this.totalPrice = value; }
        public int WeekdayRateForRewardCustomer { get => this.weekdayRateForRewardCustomer; set => this.weekdayRateForRewardCustomer = value; }
        public int WeekendRateForRewardCustomer { get => this.weekendRateForRewardCustomer; set => this.weekendRateForRewardCustomer = value; }
    }
}
