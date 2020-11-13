using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public string hotelName;
        public int weekdayRate;
        public int weekendRate;
        public int ratingsForHotel;
        public int totalPrice;

        public HotelReservation(string hotelName, int weekdayRate, int weekendRate, int ratingsForHotel)
        {
            this.hotelName = hotelName;
            this.weekdayRate = weekdayRate;
            this.weekendRate = weekendRate;
            this.ratingsForHotel = ratingsForHotel;
        }

        public HotelReservation(int totalPrice, string hotelName, int ratingsForHotel)
        {
            this.totalPrice = totalPrice;
            this.hotelName = hotelName;
            this.ratingsForHotel = ratingsForHotel;
        }

        public string HotelName { get => this.hotelName; set => this.hotelName = value; }
        public int WeekdayRate { get => this.weekdayRate; set => this.weekdayRate = value; }
        public int WeekendRate { get => this.weekendRate; set => this.weekendRate = value; }
        public int RatingsForHotel { get => this.ratingsForHotel; set => this.ratingsForHotel = value; }
        public int TotalPrice { get => this.totalPrice; set => this.totalPrice = value; }
        
    }
}
