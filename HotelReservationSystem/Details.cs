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
        List<HotelReservation> ratelist = new List<HotelReservation>();
        List<HotelReservation> minpricelist = new List<HotelReservation>();

        /// <summary>
        /// UC 1 Ability to Add Hotel with Name and Rates for Regular Customer
        /// </summary>
        public void AddHotelAndRate()
        {
            ///UC 3 Ability to add weekday and weekend rates for each Hotel
            ///UC 5 Ability to add ratings to each hotel
            hotellist.Add(new HotelReservation("Lakewood", 110,90,3));
            hotellist.Add(new HotelReservation("Bridgewood", 160,60,4));
            hotellist.Add(new HotelReservation("Ridgewood", 220,150,5));
            foreach (HotelReservation entry in hotellist)
            {
                Console.WriteLine("Hotel Name: " + entry.HotelName + "\nWeekday Rate for Regular Customer: " + entry.WeekdayRateForRegularCustomer 
                    + "\nWeekend Rate For Regular Customer: " + entry.WeekendRateForRegularCustomer + "\nHotel Ratings: " + entry.RatingsForHotel
                    + "\n/---------------------------------------------/");
            }
        }

        /// <summary>
        /// Ability to Find the cheapest hotel for given date range
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        /// <param name="checkInDay"></param>
        public void FindCheapestHotel(DateTime checkInDate, DateTime checkOutDate, string checkInDay)
        {
            TimeSpan totalDays = checkOutDate.Subtract(checkInDate);
            Console.WriteLine("-----Hotel Name with Total Price-----");
            foreach (HotelReservation hotels in hotellist)
            {
                int totalPrice = 0;
                ///UC 4 Ability to find the cheapest Hotel for a given Date Range based on weekday and weekend
                for (int i = 0; i <= totalDays.TotalDays; i++)
                {
                    if (checkInDay.Equals("Saturday") || checkInDay.Equals("Sunday"))
                    {
                        totalPrice += hotels.WeekendRateForRegularCustomer;
                    }
                    else
                    {
                        totalPrice += hotels.WeekdayRateForRegularCustomer;
                    }
                }
                Console.WriteLine("Hotel Name: " + hotels.HotelName + "\nTotal Price: " + totalPrice);
                dictionary.Add(totalPrice, hotels.HotelName);
                ratelist.Add(new HotelReservation(totalPrice, hotels.hotelName, hotels.RatingsForHotel));
            }

            ///UC 2 Ability to Find the cheapest hotel for given date range
            Console.WriteLine("-----Cheapest Hotel with Total Price-----");
            foreach (var hotelPrice in dictionary)
            {
                var sort = dictionary.OrderBy(sort => sort.Key).First();
                Console.WriteLine("Hotel Name: " + sort.Value + "\nTotal Price: " + sort.Key);
                break;
            }
        }

        /// <summary>
        /// UC 6 Ability to find the cheapest best rated hotel for a given Date Range 
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        /// <param name="checkInDay"></param>
        public void FindCheapestHotelWithRatings(DateTime checkInDate, DateTime checkOutDate, string checkInDay)
        {
            FindCheapestHotel(checkInDate, checkOutDate, checkInDay);
            foreach (HotelReservation hotels in ratelist.OrderBy(s => s.totalPrice).ToList())
            {
                if (hotels.totalPrice == ratelist.Min(s => s.totalPrice))
                {
                    minpricelist.Add(hotels);
                }
            }
            foreach (HotelReservation hotels in minpricelist)
            {
                if (hotels.RatingsForHotel == minpricelist.Max(s => s.RatingsForHotel))
                {
                    Console.WriteLine("-----Cheapest Best Rated Hotel with Total Price and Hotel Ratings-----");
                    Console.WriteLine("Hotel Name: " + hotels.hotelName + "\nTotal Price: " + hotels.totalPrice + "\nRating: " + hotels.RatingsForHotel);
                }
            }

            ///UC 7 Ability to find Best Rated Hotel for given date range
            foreach (HotelReservation hotels in ratelist)
            {
                if (hotels.RatingsForHotel == ratelist.Max(s => s.RatingsForHotel))
                {
                    Console.WriteLine("-----Best Rated Hotel-----");
                    Console.WriteLine("Hotel Name: " + hotels.hotelName + "\nTotal Price: " + hotels.totalPrice + "\nRating: " + hotels.RatingsForHotel);
                }
            }
        }
    }
}
