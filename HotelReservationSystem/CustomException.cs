using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class CustomException : Exception
    {
        public enum exceptionType
        {
            INVALID_CUSTOMER
        }

        public exceptionType type;

        public CustomException(string message, exceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}
