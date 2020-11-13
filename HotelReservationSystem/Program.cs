using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System!");
            Console.WriteLine("Enter type of Customer (Regular/Reward)");
            string customer=Console.ReadLine();
            Details details = new Details();
            details.AddHotelAndRate(customer);
            Console.WriteLine("Enter the check in date (DD/MM/YYYY)");
            string checkIn = Console.ReadLine();
            Console.WriteLine("Enter the checkout date (DD/MM/YYYY)");
            string checkOut = Console.ReadLine();
            DateTime checkInDate = DateTime.Parse(checkIn);
            DateTime checkOutDate = DateTime.Parse(checkOut);
            Console.WriteLine("Enter Check-In day");
            string checkInDay = Console.ReadLine();
            details.FindCheapestHotelWithRatings(checkInDate, checkOutDate, checkInDay);
        }
    }
}
