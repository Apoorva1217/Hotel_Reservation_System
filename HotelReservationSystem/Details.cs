using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Details : Contact
    {
        List<HotelReservation> list = new List<HotelReservation>();

        /// <summary>
        /// UC 1 Ability to Add Hotel with Name and Rates for Regular Customer
        /// </summary>
        public void AddHotelAndRate()
        {
            list.Add(new HotelReservation("Lakewood", 110));
            list.Add(new HotelReservation("Bridgewood", 160));
            list.Add(new HotelReservation("Ridgewood", 220));
            foreach (HotelReservation entry in list)
            {
                Console.WriteLine("Hotel Name: " + entry.HotelName + "\nRate for Regular Customer: " + entry.RateForRegularCustomer 
                    + "\n/******************************************/");
            }
        }
    }
}
