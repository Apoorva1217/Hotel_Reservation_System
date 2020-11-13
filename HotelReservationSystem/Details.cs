using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    public class Details : Contact
    {
        List<HotelReservation> hotellist = new List<HotelReservation>();
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        /// <summary>
        /// UC 1 Ability to Add Hotel with Name and Rates for Regular Customer
        /// </summary>
        public void AddHotelAndRate()
        {
            hotellist.Add(new HotelReservation("Lakewood", 110));
            hotellist.Add(new HotelReservation("Bridgewood", 160));
            hotellist.Add(new HotelReservation("Ridgewood", 220));
            foreach (HotelReservation entry in hotellist)
            {
                Console.WriteLine("Hotel Name: " + entry.HotelName + "\nRate for Regular Customer: " + entry.RateForRegularCustomer
                    + "\n/---------------------------------------------/");
            }
        }

        /// <summary>
        /// Ability to Find the cheapest hotel for given date range
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        /// <param name="checkInDay"></param>
        public void FindCheapestHotel(DateTime checkInDate, DateTime checkOutDate)
        {
            TimeSpan totalDays = checkOutDate.Subtract(checkInDate);
            Console.WriteLine("-----Hotel Name with Total Price-----");
            foreach (HotelReservation hotels in hotellist)
            {
                int totalPrice = 0;
                for (int i = 0; i <= totalDays.TotalDays; i++)
                {
                    totalPrice += hotels.RateForRegularCustomer;
                }
                Console.WriteLine("Hotel Name: " + hotels.HotelName + "\nTotal Price: " + totalPrice);
                dictionary.Add(totalPrice, hotels.HotelName);
            }

            ///UC 2 Ability to Find the cheapest hotel for given date range
            Console.WriteLine("-----Cheapest Hotel with Total Price-----");
            foreach (var hotelPrice in dictionary)
            {
                Console.WriteLine("Hotel Name: " + hotelPrice.Value + "\nTotal Price: " + hotelPrice.Key);
                break;
            }
        }
    }
}
