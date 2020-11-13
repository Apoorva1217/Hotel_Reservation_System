using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System!");
            Pattern pattern = new Pattern();
            Details details = new Details();
            
            Console.WriteLine("Enter type of Customer (Regular/Reward)");
            string customer=Console.ReadLine();
            details.AddHotelAndRate(customer);
            
            Console.WriteLine("Enter the checkin date (DD-MM-YYYY)");
            string checkIn = Console.ReadLine();
            pattern.ValidateDate(checkIn);
            
            Console.WriteLine("Enter the checkout date (DD-MM-YYYY)");
            string checkOut = Console.ReadLine();
            pattern.ValidateDate(checkOut);
            
            DateTime checkInDate = DateTime.Parse(checkIn);
            DateTime checkOutDate = DateTime.Parse(checkOut);
            
            Console.WriteLine("Enter Check-In day");
            string checkInDay = Console.ReadLine();
            
            details.FindCheapestHotelWithRatings(checkInDate, checkOutDate, checkInDay);
        }
    }
}
