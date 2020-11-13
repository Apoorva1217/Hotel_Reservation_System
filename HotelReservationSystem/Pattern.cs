using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HotelReservationSystem
{
    public class Pattern
    {
        public void ValidateDate(string date)
        {
            try
            {
                if (!Regex.Match(date, "^[0-9]{1,2}[-]{1}[0-9]{1,2}[-]{1}[0-9]{4}$").Success)
                {
                    Console.WriteLine("Invalid Date");
                }
                else
                {
                    Console.WriteLine("Valid Date");
                }
            }
            catch (CustomException)
            {
                throw new CustomException("Invalid Date Format", CustomException.exceptionType.INVALID_DATE);
            }
        }
    }
}
